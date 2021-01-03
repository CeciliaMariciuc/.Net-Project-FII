using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Autentification.Data;
using Autentification.Model;
using Microsoft.Extensions.Options;
using Authentication.Microservice.Model.Requests;
using Authentication.Microservice.Helpers;
using Microsoft.AspNetCore.Authorization;
using System.IdentityModel.Tokens.Jwt;
using System.Text;
using System.Security.Claims;
using System;
using Microsoft.IdentityModel.Tokens;
using Authentication.Microservice.Model.Responses;
using Authentication.Microservice.Model;

namespace Autentification.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserRepository _repository;
        private readonly AppSettings _appSettings;
        private readonly ICryptService _cryptService;
        private readonly IEmailSender _emailSender;

        public UsersController(IUserRepository repository, IOptions<AppSettings> appSettings, ICryptService cryptService, IEmailSender emailSender)
        {
            _repository = repository;
            _appSettings = appSettings.Value;
            _cryptService = cryptService;
            _emailSender = emailSender;
        }

        [HttpGet]
        [Authorize]
        public async Task<IEnumerable<User>> Get()
        {
            return await _repository.GetAll();
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<User>> GetById(string id)
        {
            User user = await _repository.GetById(id);
            if (user == null) return NotFound();
            return user;
        }

        [HttpPost("register")]
        public async Task<ActionResult<User>> Register(RegisterEntity registerEntity)
        {
            bool isEmailUsed = await _repository.IsEmailUsed(_cryptService.EncryptString(registerEntity.Email));
            if (isEmailUsed)
            {
                return BadRequest("Email already used!");
            }

            User user = new User
            {
                FirstName = _cryptService.EncryptString(registerEntity.FirstName),
                LastName = _cryptService.EncryptString(registerEntity.LastName),
                Email = _cryptService.EncryptString(registerEntity.Email),
                Password = _cryptService.EncryptString(registerEntity.Password)
        };

            await _repository.AddUser(user);

            return CreatedAtAction("GetById", new { id = user.Id }, user);

        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginEntity loginEntity)
        {
            User user = await _repository.CheckUser(_cryptService.EncryptString(loginEntity.Email), _cryptService.EncryptString(loginEntity.Password));

            if (user == null)
            {
                return BadRequest("Please enter a correct username/email and password. Note that the password field is case-sensitive.");
            }

            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.UTF8.GetBytes(_appSettings.Secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, user.Id)
                }),
                Expires = DateTime.UtcNow.AddHours(4),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            var tokenString = tokenHandler.WriteToken(token);

            LoginResponse response = new LoginResponse(tokenString, user.Id, user.Email);
            return Ok(response);
        }
    

        [HttpPut("{id}")]
        [Authorize]
        public async Task<ActionResult<User>> Update(string id, User user)
        {
            if (id != user.Id) return BadRequest();

            User requestedUser = await _repository.GetById(id);
            if (requestedUser == null) return NotFound();
            return user;
        }

        [HttpDelete("{id}")]
        [Authorize]
        public async Task<IActionResult> Delete(string id)
        {
            User requestedUser = await _repository.GetById(id);
            if (requestedUser == null) return NotFound();
            await _repository.DeleteUser(id);
            return NoContent();
        }

        [HttpGet("forgot-password/{email}")]
        public async Task<IActionResult> ForgotPassword(string email)
        {
            User user = await _repository.GetByEmail(_cryptService.EncryptString(email));

            if (user == null)
            {
                return BadRequest("There is no account associated with this email!");
            }

            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.UTF8.GetBytes(_appSettings.Secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, user.Id)
                }),
                Expires = DateTime.UtcNow.AddMinutes(30),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            var tokenString = tokenHandler.WriteToken(token);

            var message = new Message(new string[] { email }, "Recover PlayNet Account",
               "Hi! You recently requested to acces your PlayNet account. To reset your password use the following token: " + tokenString +
               " and follow this link: /account/recover-account We recommend that you keep your password secure and not share it with anyone. If you feel your password has been compromised, you can change it by going to your My Account Page.");
            _emailSender.SendEmail(message);
            return Ok(tokenString);
        }

        [HttpPut("reset-password")]
        [Authorize]
        public async Task<IActionResult> ChangePassword(LoginEntity request)
        {
            User requestedUser = await _repository.GetByEmail(_cryptService.EncryptString(request.Email));
            if (requestedUser == null)
                return NotFound();

            ChangePasswordRequest passwordRequest = new ChangePasswordRequest
            {
                UserId = requestedUser.Id,
                NewPassword = _cryptService.EncryptString(request.Password)
            };
            await _repository.ChangePassword(passwordRequest);
            return Ok("Password updated! You can login with your new password.");
        }

        [HttpPut("change-password/{id}")]
        [Authorize]
        public async Task<IActionResult> ChangePassword(string id, ChangePasswordRequest request)
        {
            if (id != request.UserId) return BadRequest();

            User requestedUser = await _repository.GetById(id);
            if (requestedUser == null) 
                return NotFound();
            request.NewPassword = _cryptService.EncryptString(request.NewPassword);
            await _repository.ChangePassword(request);
            return Ok("Changed password");
        }

    }
}

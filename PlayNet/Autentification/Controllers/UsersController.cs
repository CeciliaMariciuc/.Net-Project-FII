using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Autentification.Data;
using Autentification.Model;

namespace Autentification.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserRepository _repository;

        public UsersController(IUserRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
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

        [HttpPost]
        public async Task<IActionResult> Insert(User user)
        {
            await _repository.AddUser(user);
            return CreatedAtAction("GetById", new { id = user.Id }, user);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<User>> Update(string id, User user)
        {
            if (id != user.Id) return BadRequest();

            User requestedUser = await _repository.GetById(id);
            if (requestedUser == null) return NotFound();
            return user;
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            User requestedUser = await _repository.GetById(id);
            if (requestedUser == null) return NotFound();
            await _repository.DeleteUser(id);
            return NoContent();
        }
    }
}

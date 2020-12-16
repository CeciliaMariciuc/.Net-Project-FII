using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Authentication.Microservice.Model.Responses
{
    public class RegisterResponse
    {
        public RegisterResponse(string token, string userId, string email)
        {
            Token = token;
            UserId = userId;
            Email = email;
        }

        public string Token { get; private set; }

        public string UserId { get; private set; }

        public string Email { get; private set; }
    }
}

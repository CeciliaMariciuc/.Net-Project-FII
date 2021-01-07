namespace Authentication.Microservice.Model.Responses
{
    public class LoginResponse
    {
        public LoginResponse(string token, string userId, string email)
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

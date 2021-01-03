

namespace Authentication.Microservice.Model.Requests
{
    public class ChangePasswordRequest
    {
        public string UserId { get; set; }
        public string NewPassword { get; set; }
    }
}

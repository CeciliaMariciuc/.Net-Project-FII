using System.ComponentModel.DataAnnotations;

namespace Authentication.Microservice.Model.Requests
{
    public class LoginEntity
    {
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}

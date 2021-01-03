using Authentication.Microservice.Model;
using System.Threading.Tasks;

namespace Authentication.Microservice.Helpers
{
    public interface IEmailSender
    {
        void SendEmail(Message message);
    }
}
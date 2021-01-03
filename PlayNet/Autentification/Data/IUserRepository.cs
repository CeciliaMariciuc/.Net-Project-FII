using Autentification.Model;
using Authentication.Microservice.Model.Requests;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Autentification.Data
{
    public interface IUserRepository
    {
        Task<IEnumerable<User>> GetAll();
        Task<User> GetById(string id);
        Task<User> CheckUser(string email, string password);
        Task<User> GetByEmail(string email);
        Task<bool> IsEmailUsed(string email);
        Task AddUser(User user);
        Task UpdateUser(string id, User user);
        Task DeleteUser(string id);
        Task ChangePassword(ChangePasswordRequest request);
    }
}

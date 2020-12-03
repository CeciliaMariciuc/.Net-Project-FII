using Autentification.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Autentification.Data
{
    public interface IUserRepository
    {
        Task<IEnumerable<User>> GetAll();
        Task<User> GetById(string id);
        Task AddUser(User user);
        Task UpdateUser(string id, User user);
        Task DeleteUser(string id);
    }
}

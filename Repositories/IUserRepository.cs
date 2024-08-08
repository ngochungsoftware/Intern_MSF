using WebApp.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebApp.Repositories
{
    public interface IUserRepository : IRepository<User>
    {
        Task<User> GetByEmailAsync(string email);
        Task<IEnumerable<User>> GetUsersByCityAsync(string city);
    }
}

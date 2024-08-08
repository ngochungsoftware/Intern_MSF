using Microsoft.EntityFrameworkCore;
using WebApp.Models;
using Login.Data;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Repositories
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(ApplicationDbContext context) : base(context)
        {
        }


        public async Task<User> GetByEmailAsync(string email)
        {
            return await _dbSet.FirstOrDefaultAsync(u => u.Email == email);
        }

        public async Task<IEnumerable<User>> GetUsersByCityAsync(string city)
        {
            return await _dbSet.Where(u => u.DiaChi.Contains(city)).ToListAsync();
        }
    }
}

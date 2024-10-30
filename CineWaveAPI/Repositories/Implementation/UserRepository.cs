using CineWaveAPI.Data;
using CineWaveAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace CineWaveAPI.Repositories.Implementation
{
    public class UserRepository : IUserRepository
    {

        private readonly DataContext dataContext;
        public UserRepository(DataContext dataContext) { 
            this.dataContext = dataContext;
        }

        public async Task<IEnumerable<User>> GetUsers()
        {
            return await dataContext.Users.ToListAsync();
        }

        public async Task<User> GetUserById(string id)
        {
            return await dataContext.Users.FirstOrDefaultAsync(u => u.Uid == id);
        }

    }
}

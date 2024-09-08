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

        public async Task<User> GetUserById(int id)
        {
            return await dataContext.Users.FirstOrDefaultAsync(u => u.Id == id);
        }

        public async Task<User> CreateUser(User user)
        {
            var result = await dataContext.Users.AddAsync(user);
            await dataContext.SaveChangesAsync();
            return result.Entity;

        }

        public async Task<User> UpdateUser(User user)
        {
            var result = await dataContext.Users.FirstOrDefaultAsync(x => x.Id == user.Id);

            if (result != null)
            {
                result.UserName = user.UserName;
                result.Password = user.Password;
                result.Email = user.Email;


                await dataContext.SaveChangesAsync();
                return result;
            }

            return null;
        }

        public async void DeleteUser(int id)
        {
            var result = await dataContext.Users.FirstOrDefaultAsync(x => x.Id == id);
            if (result != null)
            {
                dataContext.Remove(result);
                await dataContext.SaveChangesAsync();

            }
        }

    }
}

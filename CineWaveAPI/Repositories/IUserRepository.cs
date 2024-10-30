using CineWaveAPI.Models;

namespace CineWaveAPI.Repositories
{
    public interface IUserRepository
    {
        Task<IEnumerable<User>> GetUsers();
        Task<User> GetUserById(string id);
    }
}

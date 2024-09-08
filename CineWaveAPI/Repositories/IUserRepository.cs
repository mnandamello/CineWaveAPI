using CineWaveAPI.Models;

namespace CineWaveAPI.Repositories
{
    public interface IUserRepository
    {


        Task<IEnumerable<User>> GetUsers();
        Task<User> GetUserById(int id);
        Task<User> CreateUser(User user);
        Task<User> UpdateUser(User user);
        void DeleteUser(int id);

        //todo: add Login and DesativarUser
    }
}

using CineWaveAPI.Data;
using CineWaveAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace CineWaveAPI.Repositories.Implementation
{
    public class CampanhaRepository : ICampanhaRepository
    {
        private readonly IUserRepository userRepository;
        private readonly DataContext dataContext;

        public CampanhaRepository(IUserRepository userRepository, DataContext dataContext)
        {
            this.userRepository = userRepository;
            this.dataContext = dataContext;
        }

        public async Task<Campanha> AddCampanha(Campanha campanha)
        {
            var user = userRepository.GetUserById(campanha.UserId);

            if (user == null) return null;

            var result = await dataContext.Campanhas.AddAsync(campanha);
            await dataContext.SaveChangesAsync();
            return result.Entity;
        }

        public async void DeleteCampanha(int id)
        {
            var result = await dataContext.Campanhas.FirstOrDefaultAsync(d => d.Id == id);

            if (result != null)
            {
                dataContext.Remove(result);
                await dataContext.SaveChangesAsync();
            }
        }

        public async Task<Campanha> GetCampanha(int id)
        {
            return await dataContext.Campanhas.FirstOrDefaultAsync(x => x.Id == id); ;
        }

        public async Task<List<Campanha>> GetCampanhaByUser(string id)
        {
            return await dataContext.Campanhas.Where(u => u.UserId == id).ToListAsync();
        }

        public async Task<IEnumerable<Campanha>> GetCampanhas()
        {
            return await dataContext.Campanhas.ToListAsync();
        }

    }
}

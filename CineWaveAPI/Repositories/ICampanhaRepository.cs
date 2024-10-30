using CineWaveAPI.Models;

namespace CineWaveAPI.Repositories
{
    public interface ICampanhaRepository
    {
        Task<IEnumerable<Campanha>> GetCampanhas();
        Task<Campanha> GetCampanha(int id);
        Task<List<Campanha>> GetCampanhaByUser(string id);
        Task<Campanha> AddCampanha(Campanha campanha);
        void DeleteCampanha(int id);

    }
}

using CineWaveAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace CineWaveAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }


        public DbSet<User> Users { get; set; }
        public DbSet<Campanha> Campanhas { get; set; }
        public DbSet<InsightMock> Insights { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<InsightMock>().HasData(

                new InsightMock()
                {

                    Id = 1,
                    MovieTitle = "Gafield 2",
                    RoiForecast = 250000,
                    MarketingChannel = "TikTok",
                    AverageCostPerClick = 1.5,
                    ConversionPrediction = 250,

                },

                new InsightMock()
                {
                    Id = 2,
                    MovieTitle = "Moana 2",
                    RoiForecast = 10000000,
                    MarketingChannel = "Instagram",
                    AverageCostPerClick = 1.3,
                    ConversionPrediction = 340,

                }
            );
        }
    }
}

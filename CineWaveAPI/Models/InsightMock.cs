using System.ComponentModel.DataAnnotations;

namespace CineWaveAPI.Models
{
    public class InsightMock
    {
        [Key]
        public int Id { get; set; }
        public string MovieTitle { get; set; }
        public int RoiForecast { get; set; }
        public string MarketingChannel { get; set; }
        public double AverageCostPerClick { get; set; }
        public int ConversionPrediction { get; set; }
    }
}

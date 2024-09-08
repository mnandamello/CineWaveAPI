namespace CineWaveAPI.Models
{
    public class Insights
    {
        public int Id { get; set; }
        public string MovieTitle { get; set; }
        public int RoiForecast { get; set; }
        public string MarketingChanne { get; set; }
        public float AverageCostPerClick { get; set; }
        public int ConversionPrediction { get; set; }
    }
}

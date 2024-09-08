namespace CineWaveAPI.Models
{
    public class Campanha
    {
        public int Id { get; set; }
        public string MovieName { get; set; }
        public string MovieTitle { get; set; }
        public string GenderMovie { get; set; }
        public string AgeRange { get; set; }
        public float Budget { get; set; }
        public int ReachExpectations { get; set; }
        public int UserId { get; set; }
    }
}

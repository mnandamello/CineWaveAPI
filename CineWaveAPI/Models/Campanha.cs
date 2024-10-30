using System.ComponentModel.DataAnnotations;

namespace CineWaveAPI.Models
{
    public class Campanha
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string MovieName { get; set; }
        [Required]
        public string MovieTitle { get; set; }
        [Required]
        public string GenderMovie { get; set; }
        [Required]
        public string AgeRange { get; set; }
        [Required]
        public float Budget { get; set; }
        [Required]
        public int ReachExpectations { get; set; }
        public string UserId { get; set; }
    }
}

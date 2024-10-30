using System.ComponentModel.DataAnnotations;

namespace CineWaveAPI.Models
{
    public class User
    {
        public string Uid { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        [EmailAddress]
        [Key]
        public string Email { get; set; }
        public string? Password { get; set; }
    }
}

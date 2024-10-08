﻿using System.ComponentModel.DataAnnotations;

namespace CineWaveAPI.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public bool IsActived { get; set; } = true;
    }
}

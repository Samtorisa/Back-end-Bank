﻿using System.ComponentModel.DataAnnotations;

namespace BankAppAPI.Models
{
    public class UserDto
    {
        public int Id { get; set; }

        [Required]
        public string Username { get; set; } = string.Empty;
        [Required]
        public string Password { get; set; } = string.Empty;

    }
}

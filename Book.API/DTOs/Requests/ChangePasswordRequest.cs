﻿using System.ComponentModel.DataAnnotations;

namespace Book.API.DTOs.Requests
{
    public class ChangePasswordRequest
    {
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; } = string.Empty;
        [Required]
        [DataType(DataType.Password)]
        [Compare(nameof(Password))]
        public string ConfirmPassword { get; set; } = string.Empty;

        public string UserId { get; set; } = string.Empty;
    }
}

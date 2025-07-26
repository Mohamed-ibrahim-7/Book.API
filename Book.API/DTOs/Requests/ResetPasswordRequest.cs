using System.ComponentModel.DataAnnotations;

namespace Book.API.DTOs.Requests
{
    public class ResetPasswordRequest
    {
        [Required]
        public string Code { get; set; } = string.Empty;
        public string UserId { get; set; }
    }
}

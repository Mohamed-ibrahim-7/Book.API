using System.ComponentModel.DataAnnotations;

namespace Book.API.DTOs.Requests
{
    public class CategoryRequest
    {
        [Required]
        [MinLength(3)]
        [MaxLength(100)]
        public string Name { get; set; } = string.Empty;
        //[CustomLengthValidation(20)]
        public string? Description { get; set; }
        public bool Status { get; set; }
    }
}

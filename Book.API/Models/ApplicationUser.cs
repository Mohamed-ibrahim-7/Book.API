using Microsoft.AspNetCore.Identity;

namespace Book.API.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FullName { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}

using Microsoft.AspNetCore.Identity;

namespace ProductStore.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string? FirstName { get; set; } // Mark as nullable
        public string? LastName { get; set; }  // Mark as nullable
    }
}
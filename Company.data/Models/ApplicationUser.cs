using Microsoft.AspNetCore.Identity;

namespace Company.data.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FristName { get; set; }
        public string LastName { get; set; }
        public bool IsActive { get; set; }
    }
}
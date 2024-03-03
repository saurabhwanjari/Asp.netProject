using Microsoft.AspNetCore.Identity;

namespace Final_Project.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string firstname { get; set; }
        public string lastname { get; set; }
        

    }
}

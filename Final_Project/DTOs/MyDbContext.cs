using Final_Project.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Final_Project.DTOs;

namespace Final_Project.Data
{
    public class MyDbContext : IdentityDbContext<ApplicationUser>
    {
        public MyDbContext(DbContextOptions options) : base(options)
        {
            
        }
        public DbSet<Final_Project.DTOs.RoleStore>? RoleStore { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}

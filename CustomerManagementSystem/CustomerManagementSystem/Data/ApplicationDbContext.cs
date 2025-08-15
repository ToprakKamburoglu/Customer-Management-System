using CustomerManagementSystem.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CustomerManagementSystem.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        //Tabloları Ekleme
        public DbSet<Customer> Customers { get; set; }
    }
}

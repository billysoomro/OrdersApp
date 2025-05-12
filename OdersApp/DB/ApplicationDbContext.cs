using OrderApp.Models;
using Microsoft.EntityFrameworkCore;

namespace OdersApp.DB
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        { 
        }

        public DbSet<Orders> Orders { get; set; }
    }
}

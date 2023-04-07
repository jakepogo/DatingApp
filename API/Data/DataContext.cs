using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        // Create a Users table, using the AppUser definition
        public DbSet<AppUser> Users {get; set; }
    }
}
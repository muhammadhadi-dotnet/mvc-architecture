using Microsoft.EntityFrameworkCore;
using mvc_architecture.Models;

namespace mvc_architecture.Data
{
        public class AppDbContext : DbContext
        {
            public AppDbContext(DbContextOptions<AppDbContext> options)
                : base(options)
            {
            }

            public DbSet<User> users { get; set; }
            // Add your DbSets here
        }
    
}

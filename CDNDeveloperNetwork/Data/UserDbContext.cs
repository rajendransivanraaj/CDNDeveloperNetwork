using Microsoft.EntityFrameworkCore;
using CDNDeveloperNetwork.Models;

namespace CDNDeveloperNetwork.Data
{
    public class UserDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public UserDbContext(DbContextOptions<UserDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Optionally, you can explicitly map the Skillsets property to a specific database type
            modelBuilder.Entity<User>()
                .Property(u => u.Skillsets)
                .HasColumnType("varchar(max)");
        }
    }
}

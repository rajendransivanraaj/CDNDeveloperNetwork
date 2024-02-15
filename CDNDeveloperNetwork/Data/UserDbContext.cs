
using global::CDNDeveloperNetwork.Models;
// UserDbContext.cs
using Microsoft.EntityFrameworkCore;
using CDNDeveloperNetwork.Models; // Assuming your User model is in this namespace

namespace CDNDeveloperNetwork.Data
{
    public class UserDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=R_SIVAN\\SQLEXPRESS;Database=CDNDeveloperNetwork;Trusted_Connection=True;");
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
using DockerTestApp.Database.Models;
using Microsoft.EntityFrameworkCore;

namespace DockerTestApp.Database
{
    public class PostgreSQLContext : DbContext
    {
        protected readonly IConfiguration _configuration;
        public DbSet<User> Users { get; set; }
        public PostgreSQLContext(IConfiguration configuration)
        {
            
            _configuration = configuration;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(_configuration.GetConnectionString("Default"));
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User { Id = 1, Name = "Bob", Email = "bob@mail.ru" },
                new User { Id = 2, Name = "Bill", Email = "bill@mail.ru" }
                );
        }
    }
}

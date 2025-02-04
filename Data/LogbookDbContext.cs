using LogbookChineseEdition.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace LogbookChineseEdition.Data
{
    public class LogbookDbContext : DbContext
    {
        private IConfiguration _configuration;

        public void LogbookChineseEdition(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(_configuration.GetConnectionString("SQLite"));
            optionsBuilder.EnableSensitiveDataLogging();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new GroupConfiguration());
            modelBuilder.ApplyConfiguration(new StudentConfiguration());
            modelBuilder.ApplyConfiguration(new GroupStudentConfiguration());
        }

        public DbSet<Student> ToDoItems { get; set; }
    }
}

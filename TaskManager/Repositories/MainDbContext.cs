using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using TaskManager.Models;
using System.Data;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace TaskManager.Repositories
{
    public class MainDbContext : DbContext
    {
        protected readonly IConfiguration Configuration;
        public DbSet<Person> Persons { get; set; } = null!;
        public DbSet<TaskRequests>Tasks { get; set; } = null!;
        public MainDbContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // connect to postgres with connection string from app settings
            options.UseNpgsql(Configuration.GetConnectionString("TaskManagerDbConnection"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>()
        .HasMany(c => c.Tasks)
        .WithOne(e => e.TaskFor);
        }
        

    }

}
using Microsoft.EntityFrameworkCore;
using TaskManager.Models;

namespace TaskManager.Repositories
{
    public class MainDbContext : DbContext
    {
        protected readonly IConfiguration Configuration;

        public MainDbContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // connect to postgres with connection string from app settings
            options.UseNpgsql(Configuration.GetConnectionString("TaskManagerDbConnection"));
        }
        public DbSet<Person> Persons { get; set; } = null!;
        public DbSet<TaskRequests> Tasks { get; set; } = null!;
    }
}

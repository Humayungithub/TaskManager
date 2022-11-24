using Microsoft.EntityFrameworkCore;

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
            options.UseNpgsql(Configuration.GetConnectionString("TaskManager_Db"));
        }
        public DbSet<Person> Persons { get; set; }
        public DbSet<TaskRequests> Tasks { get; set; }
    }
}

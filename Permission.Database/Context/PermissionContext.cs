using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Permission.Database.Mappings;
using permit =  Permission.Domain.Models;

namespace Permission.Database.Context
{
    public class PermissionContext : DbContext
    {
        private readonly IHostingEnvironment _env;
        public PermissionContext(DbContextOptions<PermissionContext> dbContextOptions, IHostingEnvironment env) : base(dbContextOptions)
        {
            _env = env;
        }

        public DbSet<permit.Permission> Permissions { get; set; }
        public DbSet<permit.PermissionType> PermissionTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PermissionMap());
            modelBuilder.ApplyConfiguration(new PermissionTypeMap());

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // get the configuration from the app settings
            var config = new ConfigurationBuilder()
                .SetBasePath(_env.ContentRootPath)
                .AddJsonFile("appsettings.json")
                .Build();

            // define the database to use
            optionsBuilder.UseSqlServer(config.GetConnectionString("DefaultConnection"));
        }
    }
}

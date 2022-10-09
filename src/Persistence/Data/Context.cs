using Domain.Users;
using Microsoft.EntityFrameworkCore;
using Persistence.Data.Configurations;

namespace Persistence.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.EnableSensitiveDataLogging(true);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new UserConfiguration());

            builder.Entity<User>().HasData(
                new User("Pablo", "Picasso", RoleEnum.Logopedist) { Id=1 },
                new User("Maaike", "VandeCasteele", RoleEnum.Patiënt) { Id = 2 }
                );

        }

        public DbSet<User> Users { get; set; }
    }
}

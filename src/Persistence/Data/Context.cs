using Domain.Levels;
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

            builder.Entity<UserHighscoresPerLevel>().HasData(
                new UserHighscoresPerLevel(1, 1, 51, DateTime.Now, 84, 45, 20, 2) { Id = 1 },
                new UserHighscoresPerLevel(2, 1, 99, DateTime.Now, 88, 26, 47, 12) { Id = 2 }
                );

            builder.Entity<Level>().HasData(
                new Level("First Level", "image1") { Id = 1 },
                new Level("Second Level", "Image2") { Id = 2 }
                );

        }

        public DbSet<User> Users { get; set; }
        public DbSet<UserHighscoresPerLevel> UserHighScores { get; set; }
        public DbSet<Level> Levels { get; set; }
    }
}

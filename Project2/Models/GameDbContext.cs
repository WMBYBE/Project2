using Microsoft.EntityFrameworkCore;

namespace Project2.Models
{
    public class GameDbContext : DbContext
    {
        public GameDbContext(DbContextOptions<GameDbContext> options) 
            : base(options)
        { }

        public DbSet<Game> Games { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Game>().HasData(
                new Game
                {
                    Id = 1,
                    Name = "Like A Dragon: Infinite Wealth",
                    ReleaseDate = "January 25th",
                    Developer = "Ryu Ga Gotoku",
                    MetaCritic = 89
                },
                new Game
                {
                    Id = 2,
                    Name = "Persona 3 Reload",
                    ReleaseDate = "Febuary 1st",
                    Developer = "Atlus",
                    MetaCritic = 87
                },
                new Game
                {
                    Id = 3,
                    Name = "Final Fantasy VII Rebirth",
                    ReleaseDate = "Febuary 29th",
                    Developer = "Square Enix Creative Buisiness Unit 1",
                    MetaCritic = 92
                },
                new Game
                {
                    Id = 4,
                    Name = "Dragons Dogma 2",
                    ReleaseDate = "March 21st",
                    Developer = "Capcom",
                    MetaCritic = 92
                },

                new Game
                {
                    Id = 5,
                    Name = "Metaphor: Refantazio",
                    ReleaseDate = "October 11",
                    Developer = "Atlus",
                    MetaCritic = 94
                }
                );
        }
    }
}

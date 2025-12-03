using Microsoft.EntityFrameworkCore;

namespace FinalProjectGroup11.Models
{
    public class MovieContext : DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> options)
        : base(options)
        { }

        public DbSet<Movie> Movies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Movie>().HasData(
                new Movie
                {
                    MovieId = 1,
                    Name = "Django Unchained",
                    Year = 2012,
                    Rating = 5
                },
                new Movie
                {
                    MovieId = 2,
                    Name = "Spider-Man: Across the Spider-Verse",
                    Year = 2023,
                    Rating = 4
                },
                new Movie
                {
                    MovieId = 3,
                    Name = "Predator Killer of Killers",
                    Year = 2025,
                    Rating = 5
                },
                new Movie
                {
                    MovieId = 4,
                    Name = "Baby Driver",
                    Year = 2017,
                    Rating = 4
                }
            );
        }
    }
}

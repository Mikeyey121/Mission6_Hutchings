using Microsoft.EntityFrameworkCore;
using MusicApplication.Models;
using MovieModel.Models;


namespace ModelTest.Models
{
    public class MusicContext : DbContext
    {
        public MusicContext(DbContextOptions<MusicContext> options) : base(options) // Constructor
        { }

        public DbSet<Movies> Movies { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 1, CategoryName = "Miscellaneous" }

                );

        }

    }
}

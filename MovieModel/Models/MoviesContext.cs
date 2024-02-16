using Microsoft.EntityFrameworkCore;
using MusicApplication.Models;


namespace ModelTest.Models
{
    public class MusicContext : DbContext
    {
        public MusicContext(DbContextOptions<MusicContext> options) : base(options) // Constructor
        { }

        public DbSet<Music> MusicForm { get; set; }
    }
}

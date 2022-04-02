using Microsoft.EntityFrameworkCore;

namespace WebApplication3.Models
{
    public class SongsContext : DbContext
    {
        public DbSet<Song> Song { get; set; }
        public SongsContext(DbContextOptions<SongsContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}

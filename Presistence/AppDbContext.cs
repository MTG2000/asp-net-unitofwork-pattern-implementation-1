using Microsoft.EntityFrameworkCore;
using repository_pattern.Domain.Models;

namespace repository_pattern.Presistence
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<VideoGame> VideoGames { get; set; }
        public DbSet<Publisher> Publishers { get; set; }



    }
}
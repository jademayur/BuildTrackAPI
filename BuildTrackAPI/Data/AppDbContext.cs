using BuildTrackAPI.models;
using Microsoft.EntityFrameworkCore;

namespace BuildTrackAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {
            
        }

        public DbSet<Company> Companies { get; set; }
    }
}

using Microsoft.EntityFrameworkCore;

namespace movies.API.Data
{
    public class MoviesContext : DbContext
    {
        public MoviesContext (DbContextOptions<MoviesContext> options)
            : base(options)
        {
        }

        public DbSet<movies.API.Models.Movie> Movie { get; set; }
    }
}

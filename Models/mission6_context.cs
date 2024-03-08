using Microsoft.EntityFrameworkCore;

namespace mission6_burrows.Models
{
    public class mission6_context : DbContext
    {
        public mission6_context(DbContextOptions<mission6_context> options) : base (options)
        {
        }

        public DbSet<Movie> Movies { get; set; } // creates database table
        public DbSet<Category> Categories { get; set; }
    }
}

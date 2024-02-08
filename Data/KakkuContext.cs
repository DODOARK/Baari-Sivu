using Microsoft.EntityFrameworkCore;

namespace Data
{
    public class CakeContext : DbContext
    {
        public CakeContext(DbContextOptions<CakeContext> options)
            : base(options)
        {

        }
        public DbSet<Models.Cake>? Cakes { get; set; }
    }
}
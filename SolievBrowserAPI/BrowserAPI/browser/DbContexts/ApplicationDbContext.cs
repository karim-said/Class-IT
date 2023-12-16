using Microsoft.EntityFrameworkCore;

namespace Soliev.DbContexts
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }
        public DbSet<Browser> browser { get; set; }
    }
}

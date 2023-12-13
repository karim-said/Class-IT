using Microsoft.EntityFrameworkCore;
using task18_1_1.Data.Model;

namespace task18_1_1.Data
{
    public class ApplicationDataContext : DbContext
    {
        public ApplicationDataContext(DbContextOptions<ApplicationDataContext> options) : base(options)
        {
        }

        public DbSet<History?> Histories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<History>()
                .HasKey(h => h.Id);


            base.OnModelCreating(modelBuilder);
            
        }
    }
}
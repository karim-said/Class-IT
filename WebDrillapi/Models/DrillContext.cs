using Microsoft.EntityFrameworkCore;

namespace WebDrillapi.Models
{
    public class DrillContext :DbContext
    {
        public DrillContext(DbContextOptions<DrillContext> options):base(options) { }
        public DbSet<Drill> Drills { get; set; }
           
        
    }
}

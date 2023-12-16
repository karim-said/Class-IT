using DrillAPI.models;
using Microsoft.EntityFrameworkCore;

namespace DrillAPI.Data
{
    public class DrillContext:DbContext
    {
        public DrillContext(DbContextOptions<DrillContext> options) : base(options) { }
        public DbSet<Drill> Drills { get; set; }
           
        
    }
}

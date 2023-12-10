using Microsoft.EntityFrameworkCore;
using WebDrillapi.Models;

namespace WebDrillapi.DData
{
    public class DrillContext : DbContext
    {
        public DrillContext(DbContextOptions<DrillContext> options) : base(options) { }
        public DbSet<Drill> Drills { get; set; }


    }
}

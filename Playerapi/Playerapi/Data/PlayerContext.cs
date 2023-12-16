using Microsoft.EntityFrameworkCore;
using Playerapi.models;

namespace Playerapi.Data
{
    public class PlayerContext:DbContext
    {
        public PlayerContext(DbContextOptions<PlayerContext> options):base(options) { }
        public DbSet<Player>Players { get; set; }
            
        
    }
}

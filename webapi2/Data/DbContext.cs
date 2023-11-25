using webapi.model;
using Microsoft.EntityFrameworkCore;

namespace webapi2.Data
{
    public class DbContextShape : DbContext
    {
        public DbContextShape(DbContextOptions options) : base(options) { }

        public DbSet<Shape> Shapes { get; set; }

    }
}

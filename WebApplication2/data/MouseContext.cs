using System;
using Microsoft.EntityFrameworkCore;

namespace DVDAPI.data
{
    public class MouseContext : DbContext
    {
        public MouseContext(DbContextOptions<MouseContext> optiopns) : base(optiopns)
        { 
        }
       
        public DbSet<Mouse_Is.Mouse> Mouse { get; set; }
    }
}
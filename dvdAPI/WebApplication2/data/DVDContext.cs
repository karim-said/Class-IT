using System;
using DVDAPI.model;
using Microsoft.EntityFrameworkCore;

namespace DVDAPI.data
{
    public class DVDContext : DbContext
    {
        public DVDContext(DbContextOptions<DVDContext> optiopns) : base(optiopns)
        {
        }
        public DbSet<DVD> DVDs { get; set; }
    }
}


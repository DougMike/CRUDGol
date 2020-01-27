using CRUDGol.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDGol.Data
{
    public class AeroContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }
        public AeroContext(DbContextOptions<AeroContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }

        public DbSet<Aeronave> Aeronave { get; set; }

    }
}

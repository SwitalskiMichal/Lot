using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lot.Encje
{
    public class LotContext : DbContext
    {
        private string pol = "Server=(localdb)\\mssqllocaldb;database=Lot;Trusted_Connection=True;";
        public DbSet<Lot> Loty { get; set; }
        public DbSet<CelLotu> CeleLotow { get; set; }
        public DbSet<Pilot> Piloci { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Lot>()
                .HasOne(lot => lot.CelLotu)
                .WithOne(celLotu => celLotu.Lot)
                .HasForeignKey<CelLotu>(celLotu => celLotu.LotId);

            modelBuilder.Entity<Lot>()
                .HasMany(lot => lot.Piloci)
                .WithOne(pilot => pilot.Lot);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(pol);
        }
    }
}

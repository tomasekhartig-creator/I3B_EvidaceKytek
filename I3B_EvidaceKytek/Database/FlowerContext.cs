using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using I3B_EvidaceKytek.models;
using Microsoft.EntityFrameworkCore;

namespace I3B_EvidaceKytek.Database
{
    public class FlowerContext : DbContext
    {
        public DbSet<Flower> Flowers { get; set; }

        public FlowerContext()
        {
            Database.EnsureCreated(); //pokud DB neexistuje tak se vytvori
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=flowerDb.db"); //nazev nasi DB
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {//data seed
            modelBuilder.Entity<Flower>().HasData(
                new Flower { Id = 1, Name = "Orchidej", Genus = "Chřestotvaré", Color = "Bílá" },
                new Flower { Id = 2, Name = "Tulipán", Genus = "Liliovité", Color = "Žlutá" }
            );
        }
    }
}

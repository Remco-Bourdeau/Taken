using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.IO;
using Microsoft.Extensions.Configuration;

namespace Model.Entities
{
    public class EFBankContext:DbContext
    {
        public static IConfigurationRoot configuration;
        public DbSet<Rekening> Rekeningen { get; set; }
        public DbSet<Klant> Klanten { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server=(localdb)\\mssqllocaldb;Database=EFBank;" +
                "Trusted_Connection=true;",
                options => options.MaxBatchSize(150));
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Klant>()
                .HasKey(x => x.KlantNr); //PK
            modelBuilder.Entity<Klant>()
                .Property(x => x.KlantNr)
                .ValueGeneratedOnAdd();
            modelBuilder.Entity<Rekening>()
                .HasKey(x => x.RekeningNr); //PK
            modelBuilder.Entity<Rekening>()
                .Property(x => x.RekeningNr)
                .ValueGeneratedNever();
            modelBuilder.Entity<Rekening>()
                .Property(y => y.RekeningNr)
                .HasColumnName("Rekeningnummer");
            modelBuilder.Entity<Klant>()
                .Property(v => v.KlantNr)
                .HasColumnName("Klantnummer");
            modelBuilder.Entity<Rekening>()
                .Property(x => x.KlantNr)
                .HasColumnName("Klant");
            modelBuilder.Entity<Klant>().HasData(
                new Klant { KlantNr = 1, Voornaam = "Marge" },
                new Klant { KlantNr = 2, Voornaam = "Homer" },
                new Klant { KlantNr = 3, Voornaam = "Lisa" },
                new Klant { KlantNr = 4, Voornaam = "Maggie" },
                new Klant { KlantNr = 5, Voornaam = "Bart" });
            modelBuilder.Entity<Rekening>().HasData(
                new Rekening { RekeningNr = "123-4567890-02", KlantNr = 1, Saldo = 1000, Soort = 'Z' },
                new Rekening { RekeningNr = "234-5678901-69", KlantNr = 1, Saldo = 2000, Soort = 'S' },
                new Rekening { RekeningNr = "345-6789012-12", KlantNr = 2, Saldo = 500, Soort = 'S' });
        }
    }
}

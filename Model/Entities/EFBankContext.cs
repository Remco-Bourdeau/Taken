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
        //public static IConfigurationRoot configuration;
        //public DbSet<Rekening> Rekeningen { get; set; }
        //public DbSet<Klant> Klanten { get; set; }
        //public DbSet<Personeelslid> Personeelsleden { get; set; }
        public DbSet<Artikel> Artikels { get; set; }
        public DbSet<FoodArtikel> FoodArtikels { get; set; }
        public DbSet<NonFoodArtikel> NonFoodArtikels { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server=(localdb)\\mssqllocaldb;Database=EFBank;" +
                "Trusted_Connection=true;",
                options => options.MaxBatchSize(150));//.UseLazyLoadingProxies();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Artikel>()
                .ToTable("Artikels")
                .HasDiscriminator<string>("Artikelgroep")
                .HasValue<FoodArtikel>("Food")
                .HasValue<NonFoodArtikel>("Non-Food");



            /*
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
            */
            //modelBuilder.Entity<Personeelslid>()
            //    .HasKey(x => x.PersoneelsNr);
            //modelBuilder.Entity<Personeelslid>()
            //    .HasOne(x => x.Manager)
            //    .WithMany(x => x.Ondergeschikten)
            //    .HasForeignKey(x => x.ManagerNr)
            //    .HasConstraintName("FK_ManagerNr");
            /*
            modelBuilder.Entity<Rekening>().HasData(
                new Rekening { RekeningNr = "123-4567890-02", KlantNr = 1, Saldo = 1000, Soort = 'Z' },
                new Rekening { RekeningNr = "234-5678901-69", KlantNr = 1, Saldo = 2000, Soort = 'S' },
                new Rekening { RekeningNr = "345-6789012-12", KlantNr = 2, Saldo = 500, Soort = 'S' });
            */
            //modelBuilder.Entity<Personeelslid>().HasData(
            //    new Personeelslid { PersoneelsNr = 1, Voornaam = "Diane"},
            //    new Personeelslid { PersoneelsNr = 2, Voornaam = "Mary", ManagerNr = 1 },
            //    new Personeelslid { PersoneelsNr = 3, Voornaam = "Jeff", ManagerNr = 1 },
            //    new Personeelslid { PersoneelsNr = 4, Voornaam = "William", ManagerNr = 2 },
            //    new Personeelslid { PersoneelsNr = 5, Voornaam = "Gerard", ManagerNr = 2 },
            //    new Personeelslid { PersoneelsNr = 6, Voornaam = "Anthony", ManagerNr = 2 },
            //    new Personeelslid { PersoneelsNr = 7, Voornaam = "Leslie", ManagerNr = 6 },
            //    new Personeelslid { PersoneelsNr = 8, Voornaam = "July", ManagerNr = 6 },
            //    new Personeelslid { PersoneelsNr = 9, Voornaam = "Steve", ManagerNr = 6 },
            //    new Personeelslid { PersoneelsNr = 10, Voornaam = "Foon Yue", ManagerNr = 6 },
            //    new Personeelslid { PersoneelsNr = 11, Voornaam = "George", ManagerNr = 6 },
            //    new Personeelslid { PersoneelsNr = 12, Voornaam = "Loui", ManagerNr = 5 },
            //    new Personeelslid { PersoneelsNr = 13, Voornaam = "Pamela", ManagerNr = 5 },
            //    new Personeelslid { PersoneelsNr = 14, Voornaam = "Larry", ManagerNr = 5 },
            //    new Personeelslid { PersoneelsNr = 15, Voornaam = "Barry", ManagerNr = 5 },
            //    new Personeelslid { PersoneelsNr = 16, Voornaam = "Andy", ManagerNr = 4 },
            //    new Personeelslid { PersoneelsNr = 17, Voornaam = "Peter", ManagerNr = 4 },
            //    new Personeelslid { PersoneelsNr = 18, Voornaam = "Tom", ManagerNr = 4 },
            //    new Personeelslid { PersoneelsNr = 19, Voornaam = "Mami", ManagerNr = 2 },
            //    new Personeelslid { PersoneelsNr = 20, Voornaam = "Yoshimi", ManagerNr = 19 },
            //    new Personeelslid { PersoneelsNr = 21, Voornaam = "Martin", ManagerNr = 5 }
            //    );
            
        }
    }
}

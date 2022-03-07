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
    class EFBankContext:DbContext
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
    }
}

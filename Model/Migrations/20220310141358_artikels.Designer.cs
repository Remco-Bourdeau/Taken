﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Model.Entities;

namespace Model.Migrations
{
    [DbContext(typeof(EFBankContext))]
    [Migration("20220310141358_artikels")]
    partial class artikels
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Model.Entities.Artikel", b =>
                {
                    b.Property<int>("ArtikelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Artikelgroep")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Naam")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ArtikelId");

                    b.ToTable("Artikels");

                    b.HasDiscriminator<string>("Artikelgroep").HasValue("Artikel");
                });

            modelBuilder.Entity("Model.Entities.FoodArtikel", b =>
                {
                    b.HasBaseType("Model.Entities.Artikel");

                    b.Property<int>("Houdbaarheid")
                        .HasColumnType("int");

                    b.HasDiscriminator().HasValue("Food");
                });

            modelBuilder.Entity("Model.Entities.NonFoodArtikel", b =>
                {
                    b.HasBaseType("Model.Entities.Artikel");

                    b.Property<int>("Garantie")
                        .HasColumnType("int");

                    b.HasDiscriminator().HasValue("Non-Food");
                });
#pragma warning restore 612, 618
        }
    }
}
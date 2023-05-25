﻿// <auto-generated />
using System;
using FormApp_Core.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FormApp_Core.Migrations
{
    [DbContext(typeof(OtomasyonAppDBContext))]
    partial class OtomasyonAppDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("FormApp_Core.Entities.Musteri", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Adres")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Eposta")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Soyad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefon")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Musteriler");
                });

            modelBuilder.Entity("FormApp_Core.Entities.Odeme", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("MusteriId")
                        .HasColumnType("int");

                    b.Property<string>("OdemeTarihi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("OdemeTutarı")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("TaksitId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Odemeler");
                });

            modelBuilder.Entity("FormApp_Core.Entities.Satis", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Adet")
                        .HasColumnType("int");

                    b.Property<Guid>("BarkodId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("MusteriId")
                        .HasColumnType("int");

                    b.Property<string>("SatisTarihi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Tutar")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Satislar");
                });

            modelBuilder.Entity("FormApp_Core.Entities.Taksit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("MusteriId")
                        .HasColumnType("int");

                    b.Property<int>("SatisId")
                        .HasColumnType("int");

                    b.Property<decimal>("TaksitTutari")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("VadeSayisi")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Taksitler");
                });

            modelBuilder.Entity("FormApp_Core.Entities.Urun", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("AlisTutar")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Isim")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Marka")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Renk")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Satilan")
                        .HasColumnType("int");

                    b.Property<decimal>("SatisTutar")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Stok")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Urunler");
                });
#pragma warning restore 612, 618
        }
    }
}

﻿// <auto-generated />
using System;
using DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace DataAccess.Migrations
{
    [DbContext(typeof(OtomasyonAppDBContext))]
    [Migration("20230612105103_mig12")]
    partial class mig12
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Entities.Concrete.Musteri", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Adres")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Eposta")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Soyad")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Telefon")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Musteriler");
                });

            modelBuilder.Entity("Entities.Concrete.Odeme", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("MusteriId")
                        .HasColumnType("integer");

                    b.Property<string>("OdemeTarihi")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<decimal>("OdemeTutarı")
                        .HasColumnType("numeric");

                    b.Property<int>("TaksitId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Odemeler");
                });

            modelBuilder.Entity("Entities.Concrete.Satis", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("Adet")
                        .HasColumnType("integer");

                    b.Property<Guid>("BarkodId")
                        .HasColumnType("uuid");

                    b.Property<int>("MusteriId")
                        .HasColumnType("integer");

                    b.Property<string>("SatisTarihi")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<decimal>("Tutar")
                        .HasColumnType("numeric");

                    b.HasKey("Id");

                    b.ToTable("Satislar");
                });

            modelBuilder.Entity("Entities.Concrete.Taksit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("MusteriId")
                        .HasColumnType("integer");

                    b.Property<int>("SatisId")
                        .HasColumnType("integer");

                    b.Property<decimal>("TaksitTutari")
                        .HasColumnType("numeric");

                    b.Property<int>("VadeSayisi")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Taksitler");
                });

            modelBuilder.Entity("Entities.Concrete.Urun", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<decimal>("AlisTutar")
                        .HasColumnType("numeric");

                    b.Property<string>("Isim")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Marka")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Renk")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Satilan")
                        .HasColumnType("integer");

                    b.Property<decimal>("SatisTutar")
                        .HasColumnType("numeric");

                    b.Property<int>("Stok")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Urunler");
                });
#pragma warning restore 612, 618
        }
    }
}

﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SistemaVentas.AccesoDatos;

#nullable disable

namespace SistemaVentas.AccesoDatos.Migrations
{
    [DbContext(typeof(SistemaVentasDbContext))]
    partial class SistemaVentasDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("SistemaVentas.Entidades.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime?>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DocumentNumber")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(500)
                        .IsUnicode(false)
                        .HasColumnType("varchar(500)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<int>("TypeDocument")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Customers", (string)null);
                });

            modelBuilder.Entity("SistemaVentas.Entidades.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Notes")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTime?>("RegisterDate")
                        .HasColumnType("DATE");

                    b.Property<string>("SkuCode")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<int>("UnitOfMeasureId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UnitOfMeasureId");

                    b.ToTable("Products", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Leche Gloria",
                            SkuCode = "00013",
                            Status = true,
                            UnitOfMeasureId = 2
                        },
                        new
                        {
                            Id = 2,
                            Name = "Leche Laive",
                            SkuCode = "00014",
                            Status = true,
                            UnitOfMeasureId = 2
                        },
                        new
                        {
                            Id = 3,
                            Name = "Barra de Halls Azul",
                            SkuCode = "45666",
                            Status = true,
                            UnitOfMeasureId = 1
                        },
                        new
                        {
                            Id = 4,
                            Name = "Barra de Halls Negro",
                            SkuCode = "35533",
                            Status = true,
                            UnitOfMeasureId = 1
                        });
                });

            modelBuilder.Entity("SistemaVentas.Entidades.UnitOfMeasure", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("UnitOfMeasures", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Code = "UND",
                            Description = "Unidad",
                            Status = true
                        },
                        new
                        {
                            Id = 2,
                            Code = "LAT",
                            Description = "Lata",
                            Status = true
                        },
                        new
                        {
                            Id = 3,
                            Code = "BOL",
                            Description = "Bolsa",
                            Status = true
                        },
                        new
                        {
                            Id = 4,
                            Code = "CAJ",
                            Description = "Caja",
                            Status = true
                        });
                });

            modelBuilder.Entity("SistemaVentas.Entidades.Product", b =>
                {
                    b.HasOne("SistemaVentas.Entidades.UnitOfMeasure", "UnitOfMeasure")
                        .WithMany("Products")
                        .HasForeignKey("UnitOfMeasureId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UnitOfMeasure");
                });

            modelBuilder.Entity("SistemaVentas.Entidades.UnitOfMeasure", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}

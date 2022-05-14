﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SistemaVentas.DataAccess;

#nullable disable

namespace SistemaVentas.DataAccess.Migrations
{
    [DbContext(typeof(SistemaVentasDbContext))]
    partial class SistemaVentasDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("SistemaVentas.Entities.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("IdentificationNumber")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("IdentificationNumber");

                    b.ToTable("Companies", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IdentificationNumber = "20549201527",
                            Name = "Bodegas el Percheron",
                            Status = true
                        });
                });

            modelBuilder.Entity("SistemaVentas.Entities.Customer", b =>
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

            modelBuilder.Entity("SistemaVentas.Entities.CustomerAddress", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<bool>("DefaultAddress")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("CustomerAddress");
                });

            modelBuilder.Entity("SistemaVentas.Entities.Product", b =>
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

                    b.Property<decimal>("UnitPrice")
                        .HasPrecision(11, 2)
                        .HasColumnType("decimal(11,2)");

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
                            UnitOfMeasureId = 2,
                            UnitPrice = 5.6m
                        },
                        new
                        {
                            Id = 2,
                            Name = "Leche Laive",
                            SkuCode = "00014",
                            Status = true,
                            UnitOfMeasureId = 2,
                            UnitPrice = 4.2m
                        },
                        new
                        {
                            Id = 3,
                            Name = "Barra de Halls Azul",
                            SkuCode = "45666",
                            Status = true,
                            UnitOfMeasureId = 1,
                            UnitPrice = 1.0m
                        },
                        new
                        {
                            Id = 4,
                            Name = "Barra de Halls Negro",
                            SkuCode = "35533",
                            Status = true,
                            UnitOfMeasureId = 1,
                            UnitPrice = 1.1m
                        });
                });

            modelBuilder.Entity("SistemaVentas.Entities.Sale", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("CustomerAddressId")
                        .HasColumnType("int");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<decimal>("GrandTotal")
                        .HasPrecision(11, 2)
                        .HasColumnType("decimal(11,2)");

                    b.Property<string>("InvoiceNumber")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.Property<DateTime>("SaleDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<int>("StoreId")
                        .HasColumnType("int");

                    b.Property<decimal>("Taxes")
                        .HasPrecision(11, 2)
                        .HasColumnType("decimal(11,2)");

                    b.Property<decimal>("TotalSale")
                        .HasPrecision(11, 2)
                        .HasColumnType("decimal(11,2)");

                    b.HasKey("Id");

                    b.HasIndex("CustomerAddressId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("InvoiceNumber");

                    b.HasIndex("StoreId");

                    b.ToTable("Sales", (string)null);
                });

            modelBuilder.Entity("SistemaVentas.Entities.SaleDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<decimal>("Quantity")
                        .HasPrecision(11, 2)
                        .HasColumnType("decimal(11,2)");

                    b.Property<int>("SaleId")
                        .HasColumnType("int");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<decimal>("Taxes")
                        .HasPrecision(11, 2)
                        .HasColumnType("decimal(11,2)");

                    b.Property<decimal>("TotalSale")
                        .HasPrecision(11, 2)
                        .HasColumnType("decimal(11,2)");

                    b.Property<decimal>("UnitPrice")
                        .HasPrecision(11, 2)
                        .HasColumnType("decimal(11,2)");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.HasIndex("SaleId");

                    b.ToTable("SaleDetail");
                });

            modelBuilder.Entity("SistemaVentas.Entities.Store", b =>
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

                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.Property<string>("FullAddress")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("Code");

                    b.HasIndex("CompanyId");

                    b.ToTable("Store");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Code = "0001",
                            CompanyId = 1,
                            FullAddress = "Av. Siempre viva 123",
                            Name = "Tienda Principal",
                            Status = true
                        },
                        new
                        {
                            Id = 2,
                            Code = "0002",
                            CompanyId = 1,
                            FullAddress = "Jr. Las Palomas 456",
                            Name = "Tienda mas pequeña",
                            Status = true
                        });
                });

            modelBuilder.Entity("SistemaVentas.Entities.UnitOfMeasure", b =>
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

            modelBuilder.Entity("SistemaVentas.Entities.CustomerAddress", b =>
                {
                    b.HasOne("SistemaVentas.Entities.Customer", "Customer")
                        .WithMany("Addresses")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("SistemaVentas.Entities.Product", b =>
                {
                    b.HasOne("SistemaVentas.Entities.UnitOfMeasure", "UnitOfMeasure")
                        .WithMany("Products")
                        .HasForeignKey("UnitOfMeasureId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UnitOfMeasure");
                });

            modelBuilder.Entity("SistemaVentas.Entities.Sale", b =>
                {
                    b.HasOne("SistemaVentas.Entities.CustomerAddress", "CustomerAddress")
                        .WithMany()
                        .HasForeignKey("CustomerAddressId");

                    b.HasOne("SistemaVentas.Entities.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SistemaVentas.Entities.Store", "Store")
                        .WithMany()
                        .HasForeignKey("StoreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("CustomerAddress");

                    b.Navigation("Store");
                });

            modelBuilder.Entity("SistemaVentas.Entities.SaleDetail", b =>
                {
                    b.HasOne("SistemaVentas.Entities.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SistemaVentas.Entities.Sale", "Sale")
                        .WithMany()
                        .HasForeignKey("SaleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("Sale");
                });

            modelBuilder.Entity("SistemaVentas.Entities.Store", b =>
                {
                    b.HasOne("SistemaVentas.Entities.Company", "Company")
                        .WithMany("Stores")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");
                });

            modelBuilder.Entity("SistemaVentas.Entities.Company", b =>
                {
                    b.Navigation("Stores");
                });

            modelBuilder.Entity("SistemaVentas.Entities.Customer", b =>
                {
                    b.Navigation("Addresses");
                });

            modelBuilder.Entity("SistemaVentas.Entities.UnitOfMeasure", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}

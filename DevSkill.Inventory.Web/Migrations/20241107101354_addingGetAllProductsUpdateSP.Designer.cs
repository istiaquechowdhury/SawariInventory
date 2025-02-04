﻿// <auto-generated />
using System;
using Inventory.Infrastructure.InventoryDb;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DevSkill.Inventory.Web.Migrations
{
    [DbContext(typeof(InventoryDbContext))]
    [Migration("20241107101354_addingGetAllProductsUpdateSP")]
    partial class addingGetAllProductsUpdateSP
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Inventory.Domain.Entities.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("Inventory.Domain.Entities.MeasurementUnit", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Symbol")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("MeasurementUnits");
                });

            modelBuilder.Entity("Inventory.Domain.Entities.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal?>("AverageCost")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Barcode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("CategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("CostPerUnit")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Dhanmondi")
                        .HasColumnType("int");

                    b.Property<string>("ImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("InStock")
                        .HasColumnType("int");

                    b.Property<string>("ItemName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("MeasurementUnitId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Mirpur")
                        .HasColumnType("int");

                    b.Property<decimal?>("Price")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<Guid?>("TaxesId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Uttara")
                        .HasColumnType("int");

                    b.Property<int>("WIP")
                        .HasColumnType("int");

                    b.Property<DateOnly>("date")
                        .HasColumnType("date");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("MeasurementUnitId");

                    b.HasIndex("TaxesId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Inventory.Domain.Entities.Reason", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Reasons");
                });

            modelBuilder.Entity("Inventory.Domain.Entities.StockAdjustment", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AdjustedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Note")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<Guid>("ReasonId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("WareHouseId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateOnly>("dateOnly")
                        .HasColumnType("date");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.HasIndex("ReasonId");

                    b.HasIndex("WareHouseId");

                    b.ToTable("Stockadjustments");
                });

            modelBuilder.Entity("Inventory.Domain.Entities.StockList", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("InHand")
                        .HasColumnType("int");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("WarehouseId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("WeightedAvgCost")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.HasIndex("WarehouseId");

                    b.ToTable("StockLists");
                });

            modelBuilder.Entity("Inventory.Domain.Entities.StockTransfer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateOnly>("Date")
                        .HasColumnType("date");

                    b.Property<Guid>("DestinationWarehouseId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Note")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("TransferBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TransferredQuantity")
                        .HasColumnType("int");

                    b.Property<Guid>("WareHouseId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("DestinationWarehouseId");

                    b.HasIndex("ProductId");

                    b.HasIndex("WareHouseId");

                    b.ToTable("Stocktransfers");
                });

            modelBuilder.Entity("Inventory.Domain.Entities.Taxes", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Percentage")
                        .HasPrecision(18, 1)
                        .HasColumnType("decimal(18,1)");

                    b.HasKey("Id");

                    b.ToTable("Taxes");
                });

            modelBuilder.Entity("Inventory.Domain.Entities.WareHouse", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("WareHouses");
                });

            modelBuilder.Entity("Inventory.Domain.Entities.Product", b =>
                {
                    b.HasOne("Inventory.Domain.Entities.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId");

                    b.HasOne("Inventory.Domain.Entities.MeasurementUnit", "MeasurementUnit")
                        .WithMany()
                        .HasForeignKey("MeasurementUnitId");

                    b.HasOne("Inventory.Domain.Entities.Taxes", "Taxes")
                        .WithMany()
                        .HasForeignKey("TaxesId");

                    b.Navigation("Category");

                    b.Navigation("MeasurementUnit");

                    b.Navigation("Taxes");
                });

            modelBuilder.Entity("Inventory.Domain.Entities.StockAdjustment", b =>
                {
                    b.HasOne("Inventory.Domain.Entities.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Inventory.Domain.Entities.Reason", "Reason")
                        .WithMany()
                        .HasForeignKey("ReasonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Inventory.Domain.Entities.WareHouse", "WareHouse")
                        .WithMany()
                        .HasForeignKey("WareHouseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("Reason");

                    b.Navigation("WareHouse");
                });

            modelBuilder.Entity("Inventory.Domain.Entities.StockList", b =>
                {
                    b.HasOne("Inventory.Domain.Entities.Product", "Product")
                        .WithMany("Stocklists")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Inventory.Domain.Entities.WareHouse", "Warehouse")
                        .WithMany("StockList")
                        .HasForeignKey("WarehouseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("Warehouse");
                });

            modelBuilder.Entity("Inventory.Domain.Entities.StockTransfer", b =>
                {
                    b.HasOne("Inventory.Domain.Entities.WareHouse", "DestinationWarehouse")
                        .WithMany()
                        .HasForeignKey("DestinationWarehouseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Inventory.Domain.Entities.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Inventory.Domain.Entities.WareHouse", "WareHouse")
                        .WithMany()
                        .HasForeignKey("WareHouseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DestinationWarehouse");

                    b.Navigation("Product");

                    b.Navigation("WareHouse");
                });

            modelBuilder.Entity("Inventory.Domain.Entities.Product", b =>
                {
                    b.Navigation("Stocklists");
                });

            modelBuilder.Entity("Inventory.Domain.Entities.WareHouse", b =>
                {
                    b.Navigation("StockList");
                });
#pragma warning restore 612, 618
        }
    }
}

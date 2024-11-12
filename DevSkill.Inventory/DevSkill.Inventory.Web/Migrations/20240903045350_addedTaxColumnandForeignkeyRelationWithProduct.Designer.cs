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
    [Migration("20240903045350_addedTaxColumnandForeignkeyRelationWithProduct")]
    partial class addedTaxColumnandForeignkeyRelationWithProduct
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
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

            modelBuilder.Entity("Inventory.Domain.Entities.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("AverageCost")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Barcode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("InStock")
                        .HasColumnType("int");

                    b.Property<string>("ItemName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<Guid>("TaxesId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("TaxesId");

                    b.ToTable("Products");
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

            modelBuilder.Entity("Inventory.Domain.Entities.Product", b =>
                {
                    b.HasOne("Inventory.Domain.Entities.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Inventory.Domain.Entities.Taxes", "Taxes")
                        .WithMany()
                        .HasForeignKey("TaxesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Taxes");
                });
#pragma warning restore 612, 618
        }
    }
}

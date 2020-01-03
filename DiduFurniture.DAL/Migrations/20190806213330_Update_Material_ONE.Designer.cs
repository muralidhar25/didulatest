﻿// <auto-generated />
using System;
using DiduFurniture.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DiduFurniture.DAL.Migrations
{
    [DbContext(typeof(DiduContext))]
    [Migration("20190806213330_Update_Material_ONE")]
    partial class Update_Material_ONE
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DiduFurniture.DAL.Models.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired();

                    b.Property<string>("City")
                        .IsRequired();

                    b.Property<string>("Country")
                        .IsRequired();

                    b.Property<string>("CustomerName")
                        .IsRequired();

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("Phone")
                        .IsRequired();

                    b.Property<string>("PortDestination");

                    b.Property<string>("State")
                        .IsRequired();

                    b.Property<int>("StoreLocationId");

                    b.Property<string>("Zipcode")
                        .IsRequired();

                    b.HasKey("CustomerId");

                    b.HasIndex("StoreLocationId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("DiduFurniture.DAL.Models.Material", b =>
                {
                    b.Property<int>("MaterialId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("MaterialImage");

                    b.Property<string>("MaterialName")
                        .IsRequired();

                    b.HasKey("MaterialId");

                    b.ToTable("Material");
                });

            modelBuilder.Entity("DiduFurniture.DAL.Models.ProductCategory", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName")
                        .IsRequired();

                    b.Property<string>("ProductCode")
                        .IsRequired();

                    b.HasKey("CategoryId");

                    b.ToTable("ProductCategory");
                });

            modelBuilder.Entity("DiduFurniture.DAL.Models.ProductDetail", b =>
                {
                    b.Property<int>("ProductDetailId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Anyam");

                    b.Property<string>("Color")
                        .IsRequired();

                    b.Property<decimal>("Height")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Length")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("MaterialId");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ProductImage")
                        .IsRequired();

                    b.Property<int>("Quantity");

                    b.Property<int>("SubCategoryId");

                    b.Property<int>("WeavingId");

                    b.Property<decimal>("Width")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ProductDetailId");

                    b.HasIndex("MaterialId");

                    b.HasIndex("SubCategoryId");

                    b.HasIndex("WeavingId");

                    b.ToTable("ProductDetail");
                });

            modelBuilder.Entity("DiduFurniture.DAL.Models.Products.MaterialWeaving", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("WeavingType")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("MaterialWeaving");
                });

            modelBuilder.Entity("DiduFurniture.DAL.Models.Products.SubCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId");

                    b.Property<int>("SubCategoryId");

                    b.HasKey("Id");

                    b.ToTable("SubCategory");
                });

            modelBuilder.Entity("DiduFurniture.DAL.Models.ProductSubCategories", b =>
                {
                    b.Property<int>("SubCategoryId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("SubCategoryId");

                    b.ToTable("ProductSubCategories");
                });

            modelBuilder.Entity("DiduFurniture.DAL.Models.Quotation.StoreLocation", b =>
                {
                    b.Property<int>("StoreLocationId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("StoreAddress")
                        .IsRequired();

                    b.Property<string>("StoreName")
                        .IsRequired();

                    b.Property<string>("ZipCode")
                        .IsRequired();

                    b.HasKey("StoreLocationId");

                    b.ToTable("StoreLocation");
                });

            modelBuilder.Entity("DiduFurniture.DAL.Models.Quotations.Quotation", b =>
                {
                    b.Property<int>("QuotationId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Balance")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ConfirmedBy");

                    b.Property<int>("CustomerId");

                    b.Property<DateTime>("DateCreated");

                    b.Property<string>("DeliveryNotes");

                    b.Property<decimal>("Deposit")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Discount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("DueDate");

                    b.Property<string>("QuotationNumber")
                        .IsRequired();

                    b.Property<string>("QuotationStatus")
                        .IsRequired();

                    b.Property<string>("SalesPerson")
                        .IsRequired();

                    b.Property<string>("ShippedBy")
                        .IsRequired();

                    b.HasKey("QuotationId");

                    b.HasIndex("CustomerId");

                    b.ToTable("Quotation");
                });

            modelBuilder.Entity("DiduFurniture.DAL.Models.Quotations.QuotationItem", b =>
                {
                    b.Property<int>("QId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Anyam");

                    b.Property<int>("CategoryId");

                    b.Property<string>("Color")
                        .IsRequired();

                    b.Property<decimal>("Height")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Length")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("MaterialId");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ProductImage")
                        .IsRequired();

                    b.Property<int>("Quantity");

                    b.Property<int>("QuotationId");

                    b.Property<int>("SubCategoryId");

                    b.Property<decimal>("Width")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("QId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("MaterialId");

                    b.HasIndex("QuotationId");

                    b.HasIndex("SubCategoryId");

                    b.ToTable("QuotationItem");
                });

            modelBuilder.Entity("DiduFurniture.DAL.Models.Users", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Password")
                        .IsRequired();

                    b.Property<string>("UserName")
                        .IsRequired();

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("DiduFurniture.DAL.Models.Customer", b =>
                {
                    b.HasOne("DiduFurniture.DAL.Models.Quotation.StoreLocation", "storeLocation")
                        .WithMany()
                        .HasForeignKey("StoreLocationId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DiduFurniture.DAL.Models.ProductDetail", b =>
                {
                    b.HasOne("DiduFurniture.DAL.Models.Material", "Material")
                        .WithMany()
                        .HasForeignKey("MaterialId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DiduFurniture.DAL.Models.ProductSubCategories", "ProductSubCategories")
                        .WithMany()
                        .HasForeignKey("SubCategoryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DiduFurniture.DAL.Models.Products.MaterialWeaving", "MaterialWeaving")
                        .WithMany()
                        .HasForeignKey("WeavingId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DiduFurniture.DAL.Models.Quotations.Quotation", b =>
                {
                    b.HasOne("DiduFurniture.DAL.Models.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DiduFurniture.DAL.Models.Quotations.QuotationItem", b =>
                {
                    b.HasOne("DiduFurniture.DAL.Models.ProductCategory", "ProductCategory")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DiduFurniture.DAL.Models.Material", "Material")
                        .WithMany()
                        .HasForeignKey("MaterialId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DiduFurniture.DAL.Models.Quotations.Quotation", "Quotation")
                        .WithMany()
                        .HasForeignKey("QuotationId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DiduFurniture.DAL.Models.ProductSubCategories", "ProductSubCategories")
                        .WithMany()
                        .HasForeignKey("SubCategoryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}

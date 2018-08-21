﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProductShop.Data;

namespace ProductShop.Data.Migrations
{
    [DbContext(typeof(ProductShopDbContext))]
    [Migration("20180728193948_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ProductShop.Data.Models.Categories", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("ProductShop.Data.Models.CategoryProducts", b =>
                {
                    b.Property<int>("ProductId");

                    b.Property<int>("CategoryId");

                    b.Property<int?>("CategoriesId");

                    b.Property<int?>("ProductsId");

                    b.HasKey("ProductId", "CategoryId");

                    b.HasIndex("CategoriesId");

                    b.HasIndex("ProductsId");

                    b.ToTable("CategoryProducts");
                });

            modelBuilder.Entity("ProductShop.Data.Models.Products", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BuyerId");

                    b.Property<string>("Name");

                    b.Property<decimal>("Price");

                    b.Property<int>("SellerId");

                    b.HasKey("Id");

                    b.HasIndex("BuyerId");

                    b.HasIndex("SellerId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("ProductShop.Data.Models.Users", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Age");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("ProductShop.Data.Models.CategoryProducts", b =>
                {
                    b.HasOne("ProductShop.Data.Models.Categories", "Categories")
                        .WithMany("CategoryProducts")
                        .HasForeignKey("CategoriesId");

                    b.HasOne("ProductShop.Data.Models.Products", "Products")
                        .WithMany("CategoryProducts")
                        .HasForeignKey("ProductsId");
                });

            modelBuilder.Entity("ProductShop.Data.Models.Products", b =>
                {
                    b.HasOne("ProductShop.Data.Models.Users", "Buyer")
                        .WithMany("ProductsBougth")
                        .HasForeignKey("BuyerId");

                    b.HasOne("ProductShop.Data.Models.Users", "Seller")
                        .WithMany("ProductsSold")
                        .HasForeignKey("SellerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}

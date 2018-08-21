using Microsoft.EntityFrameworkCore;
using ProductShop.Data.Models;
using System;

namespace ProductShop.Data
{
    public class ProductShopDbContext:DbContext
    {
        public ProductShopDbContext()
        {

        }

        public ProductShopDbContext(DbContextOptions options)
        {

        }

        public DbSet<Users> Users { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<Categories> Categories { get; set; }
        public DbSet<CategoryProducts> CategoryProducts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(Configuration.connection);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
          modelBuilder.Entity<CategoryProducts>().HasKey(p => new { p.ProductId, p.CategoryId });
           modelBuilder.Entity<Users>().HasMany(p => p.ProductsBougth).WithOne(u => u.Buyer).HasForeignKey(f => f.BuyerId);
            modelBuilder.Entity<Users>().HasMany(p => p.ProductsSold).WithOne(u => u.Seller).HasForeignKey(f => f.SellerId);
            //modelBuilder.Entity<Products>().HasMany(c => c.CategoryProducts).WithOne(p => p.Products).HasForeignKey(p => p.ProductId);
            //modelBuilder.Entity<Categories>().HasMany(c => c.CategoryProducts).WithOne(p => p.Categories).HasForeignKey(p => p.CategoryId);

        }
    }
}

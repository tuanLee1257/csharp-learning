using Microsoft.EntityFrameworkCore;
using productshop.Models;
using System;

namespace productshop.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {


        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            // Product category -- n to n
            modelBuilder.Entity<ProductCategory>().HasKey(pc => new
            {
                pc.CategoryId,
                pc.ProductId
            });
            modelBuilder.Entity<ProductCategory>().HasOne<Product>(pc => pc.Product).WithMany(p => p.ProductCategories).HasForeignKey(pc => pc.ProductId);
            modelBuilder.Entity<ProductCategory>().HasOne<Category>(pc => pc.Category).WithMany(p => p.ProductCategories).HasForeignKey(pc => pc.CategoryId);
            // User order  -- 1 to n
            modelBuilder.Entity<Order>().HasOne<User>(o => o.User).WithMany(u => u.Orders).HasForeignKey(o => o.UserId);
            // order orderDetail -- 1 to n
            modelBuilder.Entity<OrderDetail>().HasOne<Order>(od => od.Order).WithMany(o => o.OrdersDetails).HasForeignKey(od => od.OrderId);
            // Product orderDetail -- 1 to n
            modelBuilder.Entity<OrderDetail>().HasOne<Product>(od => od.Product).WithMany(p => p.OrderDetails).HasForeignKey(od => od.ProductId);
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders  { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Category> Categories  { get; set; }
    }
}

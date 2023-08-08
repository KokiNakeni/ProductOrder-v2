using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.Identity.Client;
using ProductOrder_application.Infrastructure.SeedData;
using ProductOrder_application.Models;

namespace ProductOrder_application.Infrastructure
{
    public class ProductOrder_applicationContext : DbContext
    {
        public readonly IConfiguration config;
        public readonly ProductOrder_applicationContext context;
        public ProductOrder_applicationContext(DbContextOptions<ProductOrder_applicationContext> options): base(options)
        {
            config = options;
        }
        public DbSet<StaffMemberDetails> StaffMemberDetails { get; set; }
        public DbSet<Product> Products { get; set; } = null;
        public DbSet<OrderItems> OrderItems { get; set; } = null;
        public DbSet<Order> Orders { get; set; } = null;

        public IConfiguration Configuration { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.SeedProduct();
            modelBuilder.Entity<Order>().ToTable("Order");
            modelBuilder.Entity<OrderItems>().ToTable("OrderItems");
            modelBuilder.Entity<Product>().ToTable("Product");
            modelBuilder.Entity<StaffMemberDetails>().ToTable("StaffMemberDetails");


            modelBuilder.Entity<Order>()
                .Property(o => o.TotalAmount)
                .HasColumnType("decimal(18,2)");

            modelBuilder.Entity<Product>()
                .Property(p => p.Price)
                .HasColumnType("decimal(18,2)");


            modelBuilder.Entity<OrderItems>()
                .Property(oi => oi.Quantity)
                .HasColumnType("int");

            modelBuilder.Entity<OrderItems>() // Add the TotalAmount property configuration for OrderItem
                .Property(oi => oi.TotalAmount)
                .HasColumnType("decimal(18,2)");



        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(config.GetConnectionString("Server=DESKTOP-5OC6KF6\\SQLEXPRESS;Database=ProductOrder;Integrated Security=False;Encrypt = False"));
            }

            base.OnConfiguring(optionsBuilder);
        }
    }
}

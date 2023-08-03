using System;
using Microsoft.EntityFrameworkCore;
using ProductOrder_application.Models;


namespace ProductOrder_application.Models
{
    public class ProductOrder_applicationContext : DbContext
    {
        public readonly IConfiguration config;
        public ProductOrder_applicationContext(IConfiguration options)
        {
            config = options;
        }

      //  public DbSet<StaffMemberDetails> StaffMemberDetails { get; set; }
        public DbSet<Product> Products { get; set; }
      //  public DbSet<OrderItems> OrderItems { get; set; }
       // public DbSet<Order> Orders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(config.GetConnectionString("DefaultConnection"));
            }

            base.OnConfiguring(optionsBuilder);
        }
    }
}

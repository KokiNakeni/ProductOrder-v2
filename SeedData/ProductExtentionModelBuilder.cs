using Microsoft.EntityFrameworkCore;
using ProductOrder_application.Models;

namespace ProductOrder_application.Infrastructure.SeedData
{
    public static class ProductExtensionModelBuilder
    {
        public static void SeedProduct(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    ProductTitle = "Laptop bag",
                    Price = decimal.Parse("14000.00"),
                    Description = "Sleek laptop bag",
                    Image = "laptopbags.jpg"
                });
        }
    }
}

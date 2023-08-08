//using System;
//using System.Linq;
//using System.IO;
using ProductOrder_application.Models;

namespace ProductOrder_application.Infrastructure
{
    public static class DbInitializer
    {
       public static void Initialize(ProductOrder_applicationContext context)
             
            
             context.Database.EnsureCreated();



//            Products

//        }

//        var products = new Product[]
//        {
//                new Product
//                {
//                    Id = 1,
//                    ProductTitle = "Laptop bag",
//                    Price = decimal.Parse("14000.00"),
//                    Description = "Sleek laptop bag",
//                    Image = "laptopbags.jpg"
//                },
//                 new Product
//                {
//                    Id = 2,
//                    ProductTitle = "Screens",
//                    Price = decimal.Parse("5400.00"),
//                    Description = "Sleek screen",
//                    Image = "screen.jpg"
//                },
//                new Product
//                {
//                    Id = 3,
//                    ProductTitle = "LED Mouse",
//                    Price = decimal.Parse("300.00"),
//                    Description = "Colourful mouse",
//                    Image = "ledmouse.jpg"
//                },
//                new Product
//                {
//                    Id = 4,
//                    ProductTitle = "Keyboard",
//                    Price = decimal.Parse("600.00"),
//                    Description = "Colourful keyboard",
//                    Image = "ledkeyboard.jpg"
//                },
//                new Product
//                {
//                    Id = 5,
//                    ProductTitle = "Headphones",
//                    Price = decimal.Parse("200.00"),
//                    Description = "High-quality headphones",
//                    Image = "headsets.jpg"
//                },
//                new Product
//                {
//                    Id = 6,
//                    ProductTitle = "Desk Chair",
//                    Price = decimal.Parse("1200.00"),
//                    Description = "Ergonomic desk chair",
//                    Image = "deskchair.jpg"
//                },
//                new Product
//                {
//                    Id = 7,
//                    ProductTitle = "Printer",
//                    Price = decimal.Parse("4000.00"),
//                    Description = "Fast and efficient printer",
//                    Image = "printer.jpg"
//                },
//                new Product
//                {
//                    Id = 8,
//                    ProductTitle = "External Hard Drive",
//                    Price = decimal.Parse("800.00"),
//                    Description = "1TB external hard drive",
//                    Image ="harddrive.jpg"
//                },
//                new Product
//                {
//                    Id = 9,
//                    ProductTitle = "Portable Bluetooth Speaker",
//                    Price = decimal.Parse("350.00"),
//                    Description = "Wireless speaker with great sound",
//                    Image = "speaker.jpg"
//                },
//                new Product
//                {
//                    Id = 10,
//                    ProductTitle = "Smartwatch",
//                    Price = decimal.Parse("900.00"),
//                    Description = "Fitness and health tracking smartwatch",
//                    Image = "smartwatch.jpg"
//                },
//        };

//            foreach (var product in products)
//            {
//                context.Products.Add(product);
//            }

//    Orders represent each order of each staff member or 2 orders belonging to one staff member
//    var orders = new Order[]
//    {
//                new Order { StaffId = 1, OrderDate = new DateTime(2023, 7, 15), TotalAmount = 100.50m },
//                new Order { StaffId = 2, OrderDate = new DateTime(2023, 7, 15), TotalAmount = 75.20m },
//                new Order { StaffId = 3, OrderDate = new DateTime(2023, 7, 15), TotalAmount = 50.10m },
//    };

//            foreach (var order in orders)
//            {
//                context.Orders.Add(order);
//            }

//OrderItems or cart items, I will be using this to keep track of all the orders in a basket belonging to a staff member, it also breaks the many-to-many relationship between products and order
//var orderItems = new OrderItem[]
//{
//    new OrderItem
//    {
//        StaffId = 1,
//        ProductId = 1,
//        Quantity = 2,
//        TotalAmount = 50.99m
//    },
//     Add other order item entries here
//};


//foreach (var orderItem in orderItems)
//{
//    context.OrderItems.Add(orderItem);
//}

//context.SaveChanges();
//        }
//    }
//}

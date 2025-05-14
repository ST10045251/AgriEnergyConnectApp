using AgriEnergyConnectApp.Models;
using Microsoft.EntityFrameworkCore;

namespace AgriEnergyConnectApp.Data
{
    public static class DbInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            context.Database.Migrate();

            //Checking to see if data already exists
            if (context.Farmer.Any() || context.Product.Any())
            {
                return; 
            }

            var farmer = new Farmer[]
            {
                new Farmer { Name = "Adrian Finnis", Email = "adrian.f@gmail.com", Phone = "0821234567", Address = "Farm 1, Valley Road, Western Cape" },
                new Farmer { Name = "Coral Jane", Email = "coral.j@gmail.com", Phone = "0637654321", Address = "Farm 2, Mountain View, Nothern Cape" }
            };

            context.Farmer.AddRange(farmer);
            context.SaveChanges();

            var product = new Product[]
            {
                new Product { Name = "Wheat", Category = "Grain", Quantity = 50 },
                new Product { Name = "Apples", Category = "Fruit", Quantity = 30 }
            };

            context.Product.AddRange(product);
            context.SaveChanges();
        }
    }
}

using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using AgriEnergyConnectApp.Models;

namespace AgriEnergyConnectApp.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        private const int V = 50;

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) {}

        public DbSet<Farmer> Farmer { get; set; }
        public DbSet<Product> Product { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Seeding some sample data for Farmer
            modelBuilder.Entity<Farmer>().HasData(
                new Farmer
                {
                    FarmerId = 1,
                    Name = "Adrian Finnis",
                    Email = "adrian.f@gmail.com",
                    Phone = "0811234567",
                    Address = "Farm 1, Valley Road, Western Cape"
                }
            );

            //Seeding some sample data for Product
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    ProductId = 1,
                    Name = "Maize",
                    Category = "Grain",
                    Quantity = 50,
                    FarmerId = 1
                }
            );
        }
    }
}

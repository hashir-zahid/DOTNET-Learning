using Lab11.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Lab11.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions
            <ApplicationDbContext> options)
            : base(options) { }


        public DbSet<Product> Products { set; get; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    name = "Bread",
                    Description = "Good",
                    Price = 200
                },
                new Product
                {
                    Id = 2,
                    name = "Milk",
                    Description = "Nice",
                    Price = 5000
                },
                 new Product
                 {
                     Id = 3,
                     name = "Biscuit",
                     Description = "Excellent",
                     Price = 1000
                 }
                );

        }
    }
}

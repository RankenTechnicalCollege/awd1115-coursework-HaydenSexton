using Microsoft.EntityFrameworkCore;

namespace HOT2Project.Models
{
    public class ProductContext : DbContext
    {
        public DbSet<Product> Products { get; set; } = null!;
        public DbSet<Category> Categories { get; set; } = null!;

        public ProductContext(DbContextOptions<ProductContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
new Category() { CategoryId = "E", Name = "Electronics" },
new Category() { CategoryId = "C", Name = "Clothing" },
new Category() { CategoryId = "F", Name = "Furniture" },
new Category() { CategoryId = "B", Name = "Books" },
new Category() { CategoryId = "T", Name = "Toys" },
new Category() { CategoryId = "H", Name = "Home Appliances" },
new Category() { CategoryId = "S", Name = "Sports" }
                );
            modelBuilder.Entity<Product>().HasData(
                new Product()
                {
                    ProductId = 1,
                    ProductName = "AeroFlo ATB Wheels",
                    ProductDescShort = "",
                    ProductDescLong = "",
                    ProductImage = "",
                    ProductPrice = 189,
                    ProductQty = 40,
                    CategoryId = "S"
                },
                new Product()
                {
                    ProductId = 2,
                    ProductName = "Clear Shade 85-T Glasses",
                    ProductDescShort = "",
                    ProductDescLong = "",
                    ProductImage = "",
                    ProductPrice = 45,
                    ProductQty = 14,
                    CategoryId = "C"
                },
                new Product()
                {
                    ProductId = 3,
                    ProductName = "Cosmic Elite Road Warrior Wheels",
                    ProductDescShort = "",
                    ProductDescLong = "",
                    ProductImage = "",
                    ProductPrice = 165,
                    ProductQty = 22,
                    CategoryId = "S"
                },
                new Product()
                {
                    ProductId = 4,
                    ProductName = "Cycle-Doc Pro Repair Stand",
                    ProductDescShort = "",
                    ProductDescLong = "",
                    ProductImage = "",
                    ProductPrice = 166,
                    ProductQty = 12,
                    CategoryId = "S"
                },
                new Product()
                {
                    ProductId = 5,
                    ProductName = "Dog Ear Aero-Flow Floor Pump",
                    ProductDescShort = "",
                    ProductDescLong = "",
                    ProductImage = "",
                    ProductPrice = 5,
                    ProductQty = 25,
                    CategoryId = "S"
                }
            );
        }
    }
}

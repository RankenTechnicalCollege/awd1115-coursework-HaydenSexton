using Microsoft.EntityFrameworkCore;

namespace MVCShop.Models
{
    public class ShopContext : DbContext
    {
        public ShopContext(DbContextOptions<ShopContext> options)
            : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Purchase> Purchases { get; set; }
        public DbSet<PurchaseItem> PurchaseItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>()
                .HasIndex(p => p.Slug)
                .IsUnique();

            modelBuilder.Entity<PurchaseItem>()
                .HasOne(pi => pi.Product)
                .WithMany()
                .HasForeignKey(pi => pi.ProductId);

            modelBuilder.Entity<PurchaseItem>()
                .HasOne(pi => pi.Purchase)
                .WithMany(p => p.PurchaseItems)
                .HasForeignKey(pi => pi.PurchaseId);

            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 1, Name = "Electronics" },
                new Category { CategoryId = 2, Name = "Accessories" }
            );

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    ProductId = 1,
                    Name = "Wireless Headphones",
                    Slug = "wireless-headphones",
                    ImageFileName = "headphones.jpg",
                    Description = "Noise-cancelling over-ear headphones",
                    Price = 99.99m,
                    CategoryId = 1
                },
                new Product
                {
                    ProductId = 2,
                    Name = "Portable Speaker",
                    Slug = "portable-speaker",
                    ImageFileName = "speaker.jpg",
                    Description = "Bluetooth waterproof speaker",
                    Price = 49.99m,
                    CategoryId = 1
                },
                new Product
                {
                    ProductId = 3,
                    Name = "Phone Stand",
                    Slug = "phone-stand",
                    ImageFileName = "phone-stand.jpg",
                    Description = "Adjustable aluminum stand",
                    Price = 14.99m,
                    CategoryId = 2
                },
                new Product
                {
                    ProductId = 4,
                    Name = "Gaming Mouse",
                    Slug = "gaming-mouse",
                    ImageFileName = "mouse.jpg",
                    Description = "RGB ergonomic gaming mouse",
                    Price = 39.99m,
                    CategoryId = 2
                },
                new Product
                {
                    ProductId = 5,
                    Name = "USB-C Cable",
                    Slug = "usb-c-cable",
                    ImageFileName = "usbc.jpg",
                    Description = "Fast-charging braided cable",
                    Price = 9.99m,
                    CategoryId = 2
                }
            );
        }
    }
}

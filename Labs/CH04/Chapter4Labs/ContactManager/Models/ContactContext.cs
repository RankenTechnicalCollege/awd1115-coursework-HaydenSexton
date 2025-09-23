using Microsoft.EntityFrameworkCore;
namespace ContactManager.Models
{
    public class ContactContext : DbContext
    {
        public DbSet<Contact> Contacts { get; set; } = null!;
        public DbSet<Category> Categories { get; set; } = null!;
        public ContactContext(DbContextOptions<ContactContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category() { CategoryId = 1, Name = "Friend"},
                new Category() { CategoryId = 2, Name = "Telemarketer"},
                new Category() { CategoryId = 3, Name = "Customer"},
                new Category() { CategoryId = 4, Name = "Staff"}
                );

            modelBuilder.Entity<Contact>().HasData(
                new Contact() { ContactId = 1, Firstname = "Jane", Lastname = "Doe", Phone = "123-456-1234", Email = "Email@example.com", CategoryId = 1 },
                new Contact() { ContactId = 2, Firstname = "John", Lastname = "Smith", Phone = "555-111-2222", Email = "john.smith@example.com", CategoryId = 2 },
                new Contact() { ContactId = 3, Firstname = "Emily", Lastname = "Clark", Phone = "555-333-4444", Email = "emily.clark@example.com", CategoryId = 1 },
                new Contact() { ContactId = 4, Firstname = "Michael", Lastname = "Brown", Phone = "555-555-6666", Email = "michael.brown@example.com", CategoryId = 3 }
            );
        }
    }
}

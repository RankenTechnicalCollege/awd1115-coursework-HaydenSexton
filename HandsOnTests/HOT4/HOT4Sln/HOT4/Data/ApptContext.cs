using Microsoft.EntityFrameworkCore;
using HOT4.Models;

namespace HOT4.Data
{
    public class ApptContext : DbContext
    {
        public ApptContext(DbContextOptions<ApptContext> options) : base(options) { }

        public DbSet<Appointment> Appointments => Set<Appointment>();
        public DbSet<Customer> Customers => Set<Customer>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Customer>()
                .HasMany(c => c.Appointments)
                      .WithOne(a => a.Customer)
                      .HasForeignKey(a => a.CustomerId)
                      .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Customer>().HasKey(c => c.CustomerId);

            modelBuilder.Entity<Appointment>(entity =>
            {
                entity.HasKey(a => a.AppointmentId);

                entity.Ignore(a => a.EndDateTime);
            });

            modelBuilder.Entity<Customer>().HasData(
                new Customer
                {
                    CustomerId = 1,
                    Username = "JohnDoe",
                    PhoneNumber = "555-123-4567"
                },
                new Customer
                {
                    CustomerId = 2,
                    Username = "JaneSmith",
                    PhoneNumber = "555-987-6543"
                }
             );

            modelBuilder.Entity<Appointment>().HasData(
                new Appointment
                {
                    AppointmentId = 1,
                    StartDateTime = new DateTime(2025, 3, 15, 8, 0, 0),
                    CustomerId = 1
                },
                new Appointment
                {
                    AppointmentId = 2,
                    StartDateTime = new DateTime(2025, 3, 15, 9, 0, 0),
                    CustomerId = 2
                }
            );
        }
    }
}

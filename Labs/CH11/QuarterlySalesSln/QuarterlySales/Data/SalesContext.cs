using Microsoft.EntityFrameworkCore;
using QuarterlySales.Models;

namespace QuarterlySales.Data
{
    public class SalesContext : DbContext
    {
        public SalesContext(DbContextOptions<SalesContext> options) : base(options) { }

        public DbSet<Employee> Employees => Set<Employee>();
        public DbSet<Sale> Sales => Set<Sale>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Employee>()
                .HasOne(e => e.Manager)
                .WithMany()
                .HasForeignKey(e => e.ManagerId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Sale>()
                .HasOne(s => s.Employee)
                .WithMany(e => e.Sales)
                .HasForeignKey(s => s.EmployeeId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    EmployeeId = 1,
                    FirstName = "Joyce",
                    LastName = "Valdez",
                    DOB = new DateTime(1956, 12, 10),
                    DateOfHire = new DateTime(1995, 1, 1),
                    ManagerId = 1
                },
                new Employee
                {
                    EmployeeId = 2,
                    FirstName = "Marcus",
                    LastName = "Lee",
                    DOB = new DateTime(1985, 5, 22),
                    DateOfHire = new DateTime(2010, 3, 15),
                    ManagerId = 2
                },
                new Employee
                {
                    EmployeeId = 3,
                    FirstName = "Ava",
                    LastName = "Nguyen",
                    DOB = new DateTime(1990, 8, 3),
                    DateOfHire = new DateTime(2015, 7, 20),
                    ManagerId = 2
                }
            );

            modelBuilder.Entity<Sale>().HasData(
                new Sale { SaleId = 1, Quarter = 1, Year = 2024, Amount = 32000.50m, EmployeeId = 2 },
                new Sale { SaleId = 2, Quarter = 2, Year = 2024, Amount = 27000.75m, EmployeeId = 2 },
                new Sale { SaleId = 3, Quarter = 3, Year = 2024, Amount = 41000.00m, EmployeeId = 3 },
                new Sale { SaleId = 4, Quarter = 4, Year = 2024, Amount = 38000.25m, EmployeeId = 3 }
            );
        }
    }
}

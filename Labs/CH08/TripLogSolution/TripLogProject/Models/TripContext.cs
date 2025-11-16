using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;
using TripLogProject.Models.DomainModels;

namespace TripLogProject.Models
{
    public class TripContext(DbContextOptions<TripContext> options) : DbContext(options)
    {

        public DbSet<Trip> Trips { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Trip>().HasData(
                new Trip
                {
                    TripId = 1,
                    Destination = "Portland",
                    StartDate = new DateTime(2023, 3, 1),
                    EndDate = new DateTime(2023, 3, 7),
                    Accommodations = "The Benson Hotel",
                    Phone = "503-555-1234",
                    Email = "staff@thebenson.com",
                    ThingsToDo = "Get Voodoo donuts,Walk in the rain,Go to Powell's"
                },
                new Trip
                {
                    TripId = 2,
                    Destination = "Boise",
                    StartDate = new DateTime(2023, 6, 6),
                    EndDate = new DateTime(2023, 6, 14),
                    Accommodations = "Holiday Inn Express",
                    Phone = "504-575-1254",
                    Email = "test@test.com",
                    ThingsToDo = "Visit family"
                }
            );
        }
    }
}
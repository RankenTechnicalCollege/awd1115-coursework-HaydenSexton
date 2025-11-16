using System;
using System.ComponentModel.DataAnnotations;

namespace TripLogProject.Models.DomainModels
{
    public class Trip
    {
        public int TripId { get; set; }

        [Required]
        public string Destination { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime EndDate { get; set; }

        public string Accommodations { get; set; }
        public string Phone {  get; set; }
        public string Email { get; set; }
        public string ThingsToDo { get; set; }
    }
}

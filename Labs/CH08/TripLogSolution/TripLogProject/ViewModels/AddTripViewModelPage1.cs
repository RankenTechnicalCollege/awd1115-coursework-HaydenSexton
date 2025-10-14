using System.ComponentModel.DataAnnotations;

namespace TripLogProject.ViewModels
{
    public class AddTripViewModelPage1
    {
        [Required(ErrorMessage = "Please enter a destination")]
        public string Destination { get; set; }

        [Required(ErrorMessage = "Please enter a start date")]
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }

        [Required(ErrorMessage = "Please enter a end date")]
        [DataType(DataType.Date)]
        public DateTime EndDate { get; set; }
    }
}

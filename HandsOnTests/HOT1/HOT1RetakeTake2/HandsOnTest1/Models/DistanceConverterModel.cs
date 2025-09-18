using System.ComponentModel.DataAnnotations;

namespace HandsOnTest1.Models
{
    public class DistanceConverterModel
    {
        [Required(ErrorMessage = "Please enter a number for inches.")]
        [Range(1, 500, ErrorMessage = "Please enter a value between 1 and 500.")]

        public decimal? DistanceInInches { get; set; }
        public decimal? Centimeters { get; set; }

        public decimal? GetInches()
        {
            return DistanceInInches;
        }

        public decimal? CalculateCentimeters()
        {
            decimal? centimeters = DistanceInInches * 2.54m;
            return centimeters;
        }
    }
}

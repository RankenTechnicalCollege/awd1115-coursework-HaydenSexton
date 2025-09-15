using System.ComponentModel.DataAnnotations;

namespace DistanceConverter.Models
{
    public class DistanceConverterModel
    {
        [Required(ErrorMessage = "Please enter a number for inches.")]
        [Range(0.0000001, double.MaxValue, ErrorMessage = "Please enter a value greater than 0.")]
        public decimal DistanceInInches { get; set; }
        public decimal Centimeters { get; set; }

        public decimal GetInches()
        {
            return DistanceInInches;
        }

        public decimal CalculateCentimeters()
        {
            decimal centimeters = DistanceInInches * 2.54m;
            return centimeters;
        }
    }
}

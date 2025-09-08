using System.ComponentModel.DataAnnotations;

namespace P2_2_Tip_Calculator_App.Models
{
    public class TipCalculatorModel
    {
        [Required(ErrorMessage = "Please enter a cost for the meal.")]
        [Range(0.0000001, double.MaxValue, ErrorMessage = "Please enter a value greater than 0.")]
        public decimal CostOfMeal { get; set; }

        public decimal CalculateFifteenPercent()
        {
            decimal fifteenPercent = CostOfMeal * 0.15m;
            return fifteenPercent;
        }

        public decimal CalculateTwentyPercent()
        {
            decimal twentyPercent = CostOfMeal * 0.20m;
            return twentyPercent;
        }

        public decimal CalculateTwentyFivePercent()
        {
            decimal twentyFivePercent = CostOfMeal * 0.25m;
            return twentyFivePercent;
        }
    }
}

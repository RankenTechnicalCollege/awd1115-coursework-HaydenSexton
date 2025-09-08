namespace P2_2_Tip_Calculator_App.Models
{
    public class TipCalculatorModel
    {
        public decimal CostOfMeal { get; set; }

        public decimal CalculateFifteenPercent()
        {
            decimal fifteenPercent = CostOfMeal * (15/100);
            return fifteenPercent;
        }

        public decimal Calculate
    }
}

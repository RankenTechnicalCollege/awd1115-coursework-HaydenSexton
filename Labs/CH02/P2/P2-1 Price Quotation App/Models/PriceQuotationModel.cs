using System.ComponentModel.DataAnnotations;

namespace P2_1_Price_Quotation_App.Models
{
    public class PriceQuotationModel
    {
        [Required(ErrorMessage = "Please enter a subtotal.")]
        [Range(0.0000001, double.MaxValue, ErrorMessage = "Please enter a value greater than 0.")]
        public decimal Subtotal { get; set; }

        [Required(ErrorMessage = "Please enter a discount percent.")]
        [Range(1, 100, ErrorMessage = "Please enter percent between 1 and 100.")]
        public decimal DiscountPercent { get; set; }

        public decimal CalculateTotal()
        {
            decimal discountAmount = Subtotal * (DiscountPercent / 100);
            decimal total = Subtotal - discountAmount;

            return total;
        }

        public decimal CalculateDiscountAmount()
        {
            decimal discountAmount = Subtotal * (DiscountPercent / 100);

            return discountAmount;
        }
    }
}

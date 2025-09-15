using System.ComponentModel.DataAnnotations;

namespace OrderForm.Models
{
    public class OrderFormModel
    {
        [Required(ErrorMessage = "Please enter a quantity.")]
        [Range(1, int.MaxValue, ErrorMessage = "Please enter a value greater than 0.")]
        public int Quantity { get; set; }
        public string? DiscountCode { get; set; }
        public decimal CalculateSubtotal()
        {
            decimal pricePerItem = 15.00m;
            decimal discountMultiplier = CalculateDiscount(out string discountError);

            decimal discountedPrice = pricePerItem * (1 - discountMultiplier);

            return Quantity * discountedPrice;
        }

        public decimal CalculateTax()
        {
            decimal subtotal = CalculateSubtotal();
            return subtotal * 0.08m;
        }

        public decimal CalculateTotal()
        {
            decimal subtotal = CalculateSubtotal();
            decimal tax = CalculateTax();
            return subtotal + tax;
        }

        public decimal CalculateDiscount(out string discountError)
        {
            discountError = "";

            if (DiscountCode == "6175")
            {
                return 0.3m;
            }
            else if (DiscountCode == "1390")
            {
                return 0.2m;
            }
            else if (DiscountCode == "BB88")
            {
                return 0.1m;
            }
            else if (!string.IsNullOrEmpty(DiscountCode))
            {
                discountError = "Invalid discount code. No discount applied.";
                return 0m;
            }
            else
            {
                return 0m;
            }
        }
    }
}
namespace P2_1_Price_Quotation_App.Models
{
    public class PriceQuotationModel
    {
        public decimal Subtotal { get; set; }
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

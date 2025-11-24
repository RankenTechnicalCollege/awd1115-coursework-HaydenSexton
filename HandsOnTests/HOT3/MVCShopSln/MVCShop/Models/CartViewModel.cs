namespace MVCShop.Models
{
    public class CartViewModel
    {
        public List<CartItem> Items { get; set; } = new();
        public int TotalQuantity { get; set; }
        public decimal TotalPrice { get; set; }
    }

}

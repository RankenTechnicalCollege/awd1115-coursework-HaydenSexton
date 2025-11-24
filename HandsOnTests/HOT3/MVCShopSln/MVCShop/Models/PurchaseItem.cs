namespace MVCShop.Models
{
    public class PurchaseItem
    {
        public int PurchaseItemId { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }

        // fks
        public int ProductId { get; set; }
        public int PurchaseId { get; set; }

        // Nav
        public Product Product { get; set; } = null!;
        public Purchase Purchase { get; set; } = null!;
    }

}

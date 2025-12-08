namespace MVCShop.Models
{
    public class Purchase
    {
        public int PurchaseId { get; set; }

        public DateTime Date { get; set; }
        public decimal TotalPrice { get; set; }

        public List<PurchaseItem> PurchaseItems { get; set; } = new();
    }
}

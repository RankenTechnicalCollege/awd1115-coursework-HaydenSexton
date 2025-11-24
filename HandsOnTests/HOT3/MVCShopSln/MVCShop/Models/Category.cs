namespace MVCShop.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string Name { get; set; } = string.Empty;

        // Nav
        public List<Product> Products { get; set; } = new();
    }
}
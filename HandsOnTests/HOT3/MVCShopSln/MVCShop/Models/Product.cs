using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCShop.Models
{
    public class Product
    {
        public int ProductId { get; set; }

        public string Name { get; set; } = string.Empty;
        public string ImageFileName { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal Price { get; set; }

        // fk
        public int CategoryId { get; set; }
        public Category Category { get; set; } = null!;

        public string Slug { get; set; } = string.Empty;

        [NotMapped]
        public IFormFile? ImageUpload { get; set; }
    }
}

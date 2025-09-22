using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.VisualBasic;

namespace HOT2Project.Models
{
    public class Product
    {
        public int ProductId { get; set; }

        [Required(ErrorMessage = "Please enter a product name.")]
        public string? ProductName { get; set; }

        [Required(ErrorMessage = "Please enter a short product description.")]
        public string? ProductDescShort { get; set; }

        [Required(ErrorMessage = "Please enter a long product description.")]
        public string? ProductDescLong { get; set; }

        public string? ProductImage { get; set; }

        [NotMapped]
        public IFormFile? ImageFile { get; set; }

        [Required(ErrorMessage = "Please enter a product price.")]
        [Range(1, 100000, ErrorMessage = "Please enter a value between 1 and 100,000.")]
        public decimal? ProductPrice { get; set; }

        [Required(ErrorMessage = "Please enter a product quantity.")]
        [Range(1,1000, ErrorMessage = "Please enter a value between 1 and 1,000.")]
        public int? ProductQty { get; set; }




        [Required(ErrorMessage = "Please enter a category.")]
        public string? CategoryId { get; set; }

        [ValidateNever]
        public Category Category { get; set; } = null!;




        // slug
        public string Slug => ProductName?.Replace(' ', '-').ToLower() + '-' + ProductQty?.ToString();
    }
}

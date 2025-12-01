using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVCShop.Models;

namespace MVCShop.Areas.Home.Controllers
{
    public class HomeController : Controller
    {
        private readonly ShopContext _context;

        public HomeController(ShopContext context)
        {
            _context = context;
        }

        public IActionResult Index(int? categoryId)
        {
            ViewBag.Categories = _context.Categories.ToList();

            var products = _context.Products
                .Include(p => p.Category)
                .AsQueryable();

            if (categoryId.HasValue && categoryId > 0)
            {
                products = products.Where(p => p.CategoryId == categoryId.Value);
            }

            return View(products.ToList());
        }

        public IActionResult Details(string slug)
        {
            if (slug == null)
                return NotFound();

            var product = _context.Products
                .Include(p => p.Category)
                .FirstOrDefault(p => p.Slug == slug);

            if (product == null)
                return NotFound();

            return View(product);
        }
    }
}

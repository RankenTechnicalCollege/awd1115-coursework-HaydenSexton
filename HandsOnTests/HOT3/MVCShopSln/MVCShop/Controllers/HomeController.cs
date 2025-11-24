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

        public IActionResult Index()
        {
            var products = _context.Products
                .Include(p => p.Category)
                .ToList();

            return View(products);
        }
    }
}

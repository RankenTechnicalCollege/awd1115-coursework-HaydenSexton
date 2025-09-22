using HOT2Project.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace HOT2Project.Controllers
{
    public class HomeController : Controller
    {
        private ProductContext context {  get; set; }

        public HomeController(ProductContext ctx)
        {
            context = ctx;
        }
        public IActionResult Index()
        {
            var products = context.Products.Include(p => p.Category).OrderBy(p => p.ProductName).ToList(); ;
            return View(products);
        }
    }
}

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MVCShop.Models;

namespace MVCShop.Controllers
{
    public class CartController : Controller
    {
        private readonly ShopContext _context;

        public CartController(ShopContext context)
        {
            _context = context;
        }

        private List<int> GetCartIds()
        {
            string? data = HttpContext.Session.GetString("cart");
            return string.IsNullOrEmpty(data)
                ? new List<int>()
                : data.Split(',').Select(int.Parse).ToList();
        }

        private void SaveCartIds(List<int> ids)
        {
            HttpContext.Session.SetString("cart", string.Join(",", ids));
        }

        public IActionResult Index()
        {
            var ids = GetCartIds();

            var items = ids
                .GroupBy(id => id)
                .Select(g => new CartItem
                {
                    Product = _context.Products.Find(g.Key)!,
                    Quantity = g.Count()
                })
                .ToList();

            var vm = new CartViewModel
            {
                Items = items,
                TotalQuantity = items.Sum(i => i.Quantity),
                TotalPrice = items.Sum(i => i.Product.Price * i.Quantity)
            };

            return View(vm);
        }

        [Authorize]
        public IActionResult Add(int productId)
        {
            var product = _context.Products.Find(productId);
            if (product == null)
                return NotFound();

            var ids = GetCartIds();
            ids.Add(productId);
            SaveCartIds(ids);

            TempData["message"] = $"{product.Name} added to cart!";
            return RedirectToAction("Index", "Products");
        }

        public IActionResult Remove(int productId)
        {
            var ids = GetCartIds();

            if (ids.Contains(productId))
            {
                ids.Remove(productId);
                SaveCartIds(ids);
                TempData["message"] = "Item removed.";
            }

            return RedirectToAction("Index");
        }

        public void ClearCart()
        {
            HttpContext.Session.Remove("cart");
        }
    }
}

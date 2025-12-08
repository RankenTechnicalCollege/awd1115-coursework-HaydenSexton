using Microsoft.AspNetCore.Mvc;
using MVCShop.Models;

namespace MVCShop.Controllers
{
    public class PurchaseController : Controller
    {
        private readonly ShopContext _context;

        public PurchaseController(ShopContext context)
        {
            _context = context;
        }

        private List<int> GetCartIds()
        {
            string? raw = HttpContext.Session.GetString("cart");
            if (string.IsNullOrEmpty(raw))
                return new List<int>();

            return raw.Split(',').Select(int.Parse).ToList();
        }

        public IActionResult Checkout()
        {
            var ids = GetCartIds();
            if (ids.Count == 0)
            {
                TempData["error"] = "Your cart is empty.";
                return RedirectToAction("Index", "Cart");
            }

            return RedirectToAction("CompletePurchase");
        }

        public IActionResult CompletePurchase()
        {
            var ids = GetCartIds();

            if (ids.Count == 0)
                return RedirectToAction("Index", "Cart");

            var items = ids
                .GroupBy(id => id)
                .Select(g => new
                {
                    ProductId = g.Key,
                    Quantity = g.Count(),
                    Product = _context.Products.Find(g.Key)!
                })
                .ToList();

            var purchase = new Purchase
            {
                Date = DateTime.Now,
                TotalPrice = items.Sum(i => i.Product.Price * i.Quantity),
                PurchaseItems = new List<PurchaseItem>()
            };

            foreach (var item in items)
            {
                purchase.PurchaseItems.Add(new PurchaseItem
                {
                    ProductId = item.ProductId,
                    Quantity = item.Quantity,
                    UnitPrice = item.Product.Price
                });
            }

            _context.Purchases.Add(purchase);
            _context.SaveChanges();

            HttpContext.Session.Remove("cart");

            return RedirectToAction("Complete");
        }

        public IActionResult Complete()
        {
            return View();
        }
    }
}

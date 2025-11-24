using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVCShop.Models;

namespace MVCShop.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminProductsController : Controller
    {
        private readonly ShopContext _context;

        public AdminProductsController(ShopContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var products = _context.Products
                .Include(p => p.Category)
                .OrderBy(p => p.Name)
                .ToList();

            return View(products);
        }

        public IActionResult Create()
        {
            ViewBag.Categories = _context.Categories.ToList();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Product product)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.Categories = _context.Categories.ToList();
                return View(product);
            }

            if (product.ImageUpload != null)
            {
                string fileName = Guid.NewGuid().ToString() +
                                  Path.GetExtension(product.ImageUpload.FileName);
                string uploadPath = Path.Combine(Directory.GetCurrentDirectory(),
                                                 "wwwroot/images", fileName);

                using (var stream = new FileStream(uploadPath, FileMode.Create))
                {
                    product.ImageUpload.CopyTo(stream);
                }

                product.ImageFileName = fileName;
            }

            product.Slug = product.Name.ToLower().Replace(" ", "-");

            _context.Products.Add(product);
            _context.SaveChanges();

            TempData["message"] = $"{product.Name} created!";
            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult Edit(string slug)
        {
            if (slug == null)
                return NotFound();

            var product = _context.Products
                .Include(p => p.Category)
                .FirstOrDefault(p => p.Slug == slug);

            if (product == null)
                return NotFound();

            ViewBag.Categories = _context.Categories.ToList();
            return View(product);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(string slug, Product product)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.Categories = _context.Categories.ToList();
                return View(product);
            }

            var existing = _context.Products.FirstOrDefault(p => p.Slug == slug);
            if (existing == null) return NotFound();

            existing.Name = product.Name;
            existing.Description = product.Description;
            existing.Price = product.Price;
            existing.CategoryId = product.CategoryId;

            if (product.ImageUpload != null)
            {
                string fileName = Guid.NewGuid() + Path.GetExtension(product.ImageUpload.FileName);
                string path = Path.Combine("wwwroot/images", fileName);
                using var stream = new FileStream(path, FileMode.Create);
                product.ImageUpload.CopyTo(stream);

                existing.ImageFileName = fileName;
            }

            existing.Slug = existing.Name.ToLower().Replace(" ", "-");

            _context.SaveChanges();

            TempData["message"] = "Product updated!";
            return RedirectToAction("Index");
        }



        public IActionResult Delete(string slug)
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

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(string slug)
        {
            var product = _context.Products.FirstOrDefault(p => p.Slug == slug);

            if (product != null)
            {
                _context.Products.Remove(product);
                _context.SaveChanges();
                TempData["message"] = $"{product.Name} deleted.";
            }

            return RedirectToAction("Index");
        }
    }
}

using HOT2Project.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HOT2Project.Controllers
{
    public class ProductController : Controller
    {
        private ProductContext context { get; set; }
        public ProductController(ProductContext ctx)
        {
            context = ctx;
        }

        public IActionResult List()
        {
            var products = context.Products.Include(p => p.Category).OrderBy(p => p.ProductName).ToList(); ;
            return View(products);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var product = context.Products.Find(id);
            return View(product);
        }

        [HttpPost]
        public IActionResult Delete(Product product)
        {
            context.Products.Remove(product);
            context.SaveChanges();
            return RedirectToAction("List");
        }

        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Add New Product";
            ViewBag.Categories = context.Categories.OrderBy(c => c.Name).ToList();
            return View("Edit", new Product());
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit Product";
            var product = context.Products.Find(id);
            return View(product);
        }

        [HttpPost]
        public IActionResult Edit(Product product)
        {
            if (ModelState.IsValid)
            {
                if (product.ImageFile != null && product.ImageFile.Length > 0)
                {
                    var fileName = Path.GetFileName(product.ImageFile.FileName);
                    var uploadsFolder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images");
                    if (!Directory.Exists(uploadsFolder))
                        Directory.CreateDirectory(uploadsFolder);

                    var filePath = Path.Combine(uploadsFolder, fileName);
                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        product.ImageFile.CopyTo(stream);
                    }

                    product.ProductImage = fileName;
                }
                else
                {
                    var existingProduct = context.Products.AsNoTracking()
                        .FirstOrDefault(p => p.ProductId == product.ProductId);
                    if (existingProduct != null)
                    {
                        product.ProductImage = existingProduct.ProductImage;
                    }
                }

                if (product.ProductId == 0)
                    context.Products.Add(product);
                else
                    context.Products.Update(product);

                context.SaveChanges();
                return RedirectToAction("List");
            }

            ViewBag.Action = (product.ProductId == 0) ? "Add" : "Edit";
            ViewBag.Categories = context.Categories.OrderBy(c => c.Name).ToList();  
            return View(product);
        }

        public IActionResult Index()
        {
            return RedirectToAction("List");
        }
    }
}

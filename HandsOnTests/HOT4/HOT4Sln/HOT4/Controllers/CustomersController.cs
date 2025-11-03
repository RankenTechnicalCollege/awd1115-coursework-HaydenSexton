using HOT4.Data;
using HOT4.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Threading.Tasks;

namespace HOT4.Controllers
{
    public class CustomersController : Controller
    {
        private readonly ApptContext _context; 
        public CustomersController (ApptContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Customers = new SelectList(_context.Customers.ToList(),
                "CustomerId", "Username");

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Customer customer) // create method
        {
            bool duplicate = _context.Customers.Any(e =>
            e.Username == customer.Username &&
            e.PhoneNumber == customer.PhoneNumber);

            if (duplicate)
                ModelState.AddModelError("", "A customer with the same username or phone number already exists.");

            
            // when successful
            if (ModelState.IsValid)
            {
                _context.Customers.Add(customer);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index", "Home");
            }

            return View(customer);
        }
    }
}

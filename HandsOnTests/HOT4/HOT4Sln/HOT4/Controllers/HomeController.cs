using System.Diagnostics;
using HOT4.Data;
using HOT4.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace HOT4.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApptContext _context;
        public HomeController(ApptContext context)
        {
            _context = context;
        }

        public IActionResult Index(int? customerId)
        {
            var customers = _context.Customers.ToList();
            var appointments = _context.Appointments.Include(s => s.Customer).AsQueryable();

            if (customerId.HasValue && customerId.Value > 0)
                appointments = appointments.Where(s => s.CustomerId == customerId);

            ViewBag.CustomerList = new SelectList(customers, "CustomerId", "Username", customerId);
            return View(appointments.OrderBy(s => s.StartDateTime).ToList());
        }
    }
}

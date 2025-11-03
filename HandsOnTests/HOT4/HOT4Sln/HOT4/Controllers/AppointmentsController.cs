using HOT4.Data;
using HOT4.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Threading.Tasks;

namespace HOT4.Controllers
{
    public class AppointmentsController : Controller
    {
        private readonly ApptContext _context;
        public AppointmentsController(ApptContext context)
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
        public async Task<IActionResult> Create(Appointment appointment)
        {
            bool exists = _context.Appointments.Any(a =>
            a.CustomerId == appointment.CustomerId);

            if (exists)
                ModelState.AddModelError("", "Appointment already exists for customer.");

            if (ModelState.IsValid)
            {
                _context.Appointments.Add(appointment);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index", "Home");
            }

            return View(appointment);
        }
    }
}

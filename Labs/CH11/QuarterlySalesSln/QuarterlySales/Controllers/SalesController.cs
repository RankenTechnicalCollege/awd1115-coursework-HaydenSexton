using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using QuarterlySales.Data;
using QuarterlySales.Models;

namespace QuarterlySales.Controllers
{
    public class SalesController : Controller
    {
        private readonly SalesContext _context; // bring in salescontext
        public SalesController(SalesContext context) => _context = context; // constructor

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Employees = new SelectList(_context.Employees.ToList(), "EmployeeId", "FullName");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Sale sale)
        {
            // finding duplicates but for sales
            bool exists = _context.Sales.Any(s =>
                s.EmployeeId == sale.EmployeeId &&
                s.Quarter == sale.Quarter &&
                s.Year == sale.Year);

            if (exists)
                ModelState.AddModelError("", "Sales data already exists for that employee and quarter/year.");

            if (ModelState.IsValid)
            {
                _context.Sales.Add(sale);
                _context.SaveChanges();
                return RedirectToAction("Index", "Home");
            }

            ViewBag.Employees = new SelectList(_context.Employees.ToList(), "EmployeeId", "FullName", sale.EmployeeId);
            return View(sale);
        }
    }
}

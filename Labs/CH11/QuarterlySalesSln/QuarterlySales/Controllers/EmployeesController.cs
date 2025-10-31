using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using QuarterlySales.Data;
using QuarterlySales.Models;

namespace QuarterlySales.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly SalesContext _context; // bring in sales context
        public EmployeesController(SalesContext context) => _context = context; // constructor

        [HttpGet]
        public IActionResult Create() // list of all employees
        {
            ViewBag.Managers = new SelectList(_context.Employees.ToList(), "EmployeeId", "FullName"); 
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Employee employee)
        {
            // find any duplicate names
            bool duplicate = _context.Employees.Any(e =>
                e.FirstName == employee.FirstName &&
                e.LastName == employee.LastName &&
                e.DOB.Date == employee.DOB.Date);

            // validation for duplicates
            if (duplicate)
                ModelState.AddModelError("", "An employee with the same name and date of birth already exists.");

            if (employee.ManagerId == employee.EmployeeId)
                ModelState.AddModelError(nameof(employee.ManagerId), "An employee cannot be their own manager.");

            if (employee.ManagerId.HasValue)
            {
                var manager = _context.Employees
                    .AsNoTracking()
                    .FirstOrDefault(m => m.EmployeeId == employee.ManagerId);

                if (manager != null &&
                    manager.FirstName.Equals(employee.FirstName, StringComparison.OrdinalIgnoreCase) &&
                    manager.LastName.Equals(employee.LastName, StringComparison.OrdinalIgnoreCase) &&
                    manager.DOB.Date == employee.DOB.Date)
                {
                    ModelState.AddModelError(nameof(employee.ManagerId),
                        "An employee cannot have a manager with the same name and date of birth.");
                }
            }

            // if successful, save to db
            if (ModelState.IsValid)
            {
                _context.Employees.Add(employee);
                _context.SaveChanges();
                return RedirectToAction("Index", "Home");
            }

            ViewBag.Managers = new SelectList(_context.Employees.ToList(), "EmployeeId", "FullName", employee.ManagerId);
            return View(employee);
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using QuarterlySales.Data;
using QuarterlySales.Models;
using System.Diagnostics;

namespace QuarterlySales.Controllers
{
    public class HomeController : Controller
    {
        private readonly SalesContext _context; // bring in salescontext
        public HomeController(SalesContext context) => _context = context; //constructor

        // get all sales/employees
        public IActionResult Index(int? employeeId)
        {
            var employees = _context.Employees.ToList();
            var sales = _context.Sales.Include(s => s.Employee).AsQueryable();

            if (employeeId.HasValue && employeeId.Value > 0)
                sales = sales.Where(s => s.EmployeeId == employeeId);

            ViewBag.EmployeeList = new SelectList(employees, "EmployeeId", "FullName", employeeId);
            return View(sales.OrderBy(s => s.Year).ThenBy(s => s.Quarter).ToList());
        }
    }
}

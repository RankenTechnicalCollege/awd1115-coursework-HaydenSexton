using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TripLogProject.Models;

namespace TripLogProject.Controllers
{
    public class HomeController : Controller
    {
        private TripContext context;

        public HomeController(TripContext ctx)
        {
            context = ctx;
        }

        public IActionResult Index()
        {
            if (TempData.ContainsKey("SuccessMessage"))
            {
                ViewBag.SuccessMessage = TempData["SuccessMessage"];
            }

            var trips = context.Trips.OrderBy(t => t.StartDate).ToList();
            return View(trips);
        }
    }
}

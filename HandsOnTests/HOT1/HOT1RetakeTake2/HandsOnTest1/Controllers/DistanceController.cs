using Microsoft.AspNetCore.Mvc;
using HandsOnTest1.Models;

namespace HandsOnTest1.Controllers
{
    public class DistanceController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.DistanceInInches = 0;
            ViewBag.centimeters = 0;
            return View();
        }

        [HttpPost]
        public IActionResult Index(DistanceConverterModel model)
        {
            if (ModelState.IsValid)
            {
                ViewBag.DistanceInInches = model.GetInches();
                ViewBag.centimeters = model.CalculateCentimeters();
            }
            else
            {
                ViewBag.DistanceInInches = 0;
                ViewBag.centimeters = 0;
            }
            return View(model); // bind model to view
        }
    }
}

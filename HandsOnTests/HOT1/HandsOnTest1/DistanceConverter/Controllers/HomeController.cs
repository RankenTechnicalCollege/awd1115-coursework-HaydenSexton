using DistanceConverter.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DistanceConverter.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.DistanceInInches = 0;
            ViewBag.centimeters = 0;
            return View();
        }

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

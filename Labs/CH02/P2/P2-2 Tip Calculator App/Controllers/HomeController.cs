using Microsoft.AspNetCore.Mvc;
using P2_2_Tip_Calculator_App.Models;
using System.Diagnostics;

namespace P2_2_Tip_Calculator_App.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.fifteen = 0;
            ViewBag.twenty = 0;
            ViewBag.twentyFive = 0;
            return View();
        }

        public IActionResult Index(TipCalculatorModel model)
        {
            if (ModelState.IsValid)
            {
                ViewBag.fifteen = model.CalculateFifteenPercent();
                ViewBag.twenty = model.CalculateTwentyPercent();
                ViewBag.twentyFive = model.CalculateTwentyFivePercent();
            }
            else
            {
                ViewBag.fifteen = 0;
                ViewBag.twenty = 0;
                ViewBag.twentyFive = 0;
            }
            return View(model); // bind model to view
        }
    }
}

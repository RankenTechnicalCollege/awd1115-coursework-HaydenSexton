using Microsoft.AspNetCore.Mvc;
using P2_1_Price_Quotation_App.Models;
using System.Diagnostics;

namespace P2_1_Price_Quotation_App.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.DiscountAmount = 0;
            ViewBag.Total = 0;
            return View();
        }

        public IActionResult Index(PriceQuotationModel model)
        {
            if (ModelState.IsValid)
            {
                ViewBag.DiscountAmount = model.CalculateDiscountAmount();
                ViewBag.Total = model.CalculateTotal();
            } else
            {
                ViewBag.DiscountAmount = 0;
                ViewBag.Total = 0;
            }
            return View(model); // bind model to view
        }
    }
}

using HandsOnTest1.Models;
using Microsoft.AspNetCore.Mvc;

namespace HandsOnTest1.Controllers
{
    public class OrderController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.Subtotal = 0;
            ViewBag.Total = 0;
            ViewBag.Tax = 0;
            ViewBag.DiscountError = "";
            return View(new OrderFormModel());
        }

        [HttpPost]
        public IActionResult Index(OrderFormModel model)
        {
            if (ModelState.IsValid)
            {
                string discountError;
                model.CalculateDiscount(out discountError);

                ViewBag.Subtotal = model.CalculateSubtotal();
                ViewBag.Total = model.CalculateTotal();
                ViewBag.Tax = model.CalculateTax();
                ViewBag.DiscountError = discountError;
                ViewBag.Quantity = model.Quantity;
            }
            else
            {
                ViewBag.Subtotal = 0;
                ViewBag.Total = 0;
                ViewBag.Tax = 0;
                ViewBag.DiscountError = "";
                ViewBag.Quantity = 0;
            }
            return View(model);
        }
    }
}

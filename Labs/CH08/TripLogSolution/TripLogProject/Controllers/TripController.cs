using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TripLogProject.Models;
using TripLogProject.Models.DomainModels;
using TripLogProject.ViewModels;

namespace TripLogProject.Controllers
{
    public class TripController : Controller
    {
        private TripContext context;

        public TripController(TripContext ctx) => context = ctx;

        [HttpGet]
        public IActionResult AddPage1()
        {
            ViewBag.SubHeader = "Add Trip Destination and Dates";
            return View();
        }

        [HttpPost]
        public IActionResult AddPage1(AddTripViewModelPage1 vm)
        {
            if (ModelState.IsValid)
            {
                TempData["Destination"] = vm.Destination;
                TempData["StartDate"] = vm.StartDate.ToString("yyyy-MM-dd");
                TempData["EndDate"] = vm.EndDate.ToString("yyyy-MM-dd");

                return RedirectToAction("AddPage2");
            }

            ViewBag.SubHeader = "Add Trip Destination and Dates";
            return View(vm);
        }

        [HttpGet]
        public IActionResult AddPage2()
        {
            if (TempData["Destination"] != null)
            {
                ViewBag.SubHeader = $"Add Info for {TempData["Destination"]}";
                TempData.Keep();
            }
            else
            {
                ViewBag.SubHeader = "Add Accommodations";
            }

            return View();
        }

        [HttpPost]
        public IActionResult AddPage2(AddTripViewModelPage2 vm)
        {
            if (ModelState.IsValid)
            {
                TempData["Accommodations"] = vm.Accommodations;
                TempData["Phone"] = vm.Phone;
                TempData["Email"] = vm.Email;

                return RedirectToAction("AddPage3");
            }

            if (TempData["Destination"] != null)
            {
                ViewBag.SubHeader = $"Add Info for {TempData["Destination"]}";
                TempData.Keep();
            }

            return View(vm);
        }

        [HttpGet]
        public IActionResult AddPage3()
        {
            if (TempData["Destination"] != null)
            {
                ViewBag.SubHeader = $"Add Things To Do in {TempData["Destination"]}";
                TempData.Keep();
            }
            else
            {
                ViewBag.SubHeader = "Add Things To Do";
            }

            return View();
        }

        [HttpPost]
        public IActionResult AddPage3(AddTripViewModelPage3 vm)
        {
            if (ModelState.IsValid)
            {
                var trip = new Trip
                {
                    Destination = TempData["Destination"]?.ToString(),
                    StartDate = DateTime.Parse(TempData["StartDate"]?.ToString()),
                    EndDate = DateTime.Parse(TempData["EndDate"]?.ToString()),
                    Accommodations = TempData["Accommodations"]?.ToString(),
                    Phone = TempData["Phone"]?.ToString(),
                    Email = TempData["Email"]?.ToString(),
                    ThingsToDo = vm.ThingsToDo
                };

                context.Trips.Add(trip);
                context.SaveChanges();

                TempData.Clear();

                TempData["SuccessMessage"] = $"Trip to {trip.Destination} added.";

                return RedirectToAction("Index", "Home");
            }

            if (TempData["Destination"] != null)
            {
                ViewBag.SubHeader = $"Add Things To Do in {TempData["Destination"]}";
                TempData.Keep();
            }

            return View(vm);
        }

        public IActionResult Cancel()
        {
            TempData.Clear();
            return RedirectToAction("Index", "Home");
        }
    }
}
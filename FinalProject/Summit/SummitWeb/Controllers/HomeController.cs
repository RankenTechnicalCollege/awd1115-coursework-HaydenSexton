using Microsoft.AspNetCore.Mvc;
using SummitWeb.Models;
using System.Diagnostics;

namespace SummitWeb.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

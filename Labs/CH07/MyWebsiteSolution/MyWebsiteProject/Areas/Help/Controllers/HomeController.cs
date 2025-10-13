using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace MyWebsiteProject.Areas.Help.Controllers
{
    [Area("Help")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace MyWebsiteProject.Areas.Help.Controllers
{
    [Area("Help")]
    public class TutorialController : Controller
    {
        public IActionResult Page1() => View();
        public IActionResult Page2() => View();
        public IActionResult Page3() => View();
    }
}

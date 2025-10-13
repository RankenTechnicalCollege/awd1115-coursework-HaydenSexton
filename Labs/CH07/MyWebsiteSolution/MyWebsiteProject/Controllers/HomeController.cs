using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyWebsiteProject.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() => View();

        public IActionResult About() => View();

        public IActionResult Contact()
        {
            var contacts = new Dictionary<string, string>
            {
                { "Phone", "555-123-4567" },
                { "Email", "me@mywebsite.com" },
                { "Facebook", "facebook.com/mywebsite" }
            };

            return View(contacts);
        }
    }
}

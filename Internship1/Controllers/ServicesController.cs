using Microsoft.AspNetCore.Mvc;

namespace Internship1.Controllers
{
    public class ServicesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SocialMediaManagement()
        {
            return View();
        }

        public IActionResult SocialMediaAdvertising()
        {
            return View();
        }

    }
}

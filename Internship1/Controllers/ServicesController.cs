using Microsoft.AspNetCore.Mvc;

namespace Internship1.Controllers
{
    public class ServicesController : Controller
    {
        [HttpGet("tr/hizmetler")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("tr/sosyal-medya-yonetimi")]
        public IActionResult SocialMediaManagement()
        {
            return View();
        }

        [HttpGet("tr/sosyal-medya-reklami")]
        public IActionResult SocialMediaAdvertising()
        {
            return View();
        }

    }
}

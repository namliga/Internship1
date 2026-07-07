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

        [HttpGet("tr/icerik-uretimi")]
        public IActionResult ContentProduction()
        {
            return View();
        }

        [HttpGet("tr/dijital-strateji")]
        public IActionResult DigitalStrategy()
        {
            return View();
        }

        [HttpGet("tr/performans-analizi")]
        public IActionResult PerformanceAnalysis()
        {
            return View();
        }

    }
}

using Microsoft.AspNetCore.Mvc;

namespace Internship1.Controllers
{
    public class ContactController : Controller
    {
        [HttpGet("tr/iletisim")]
        public IActionResult Index()
        {
            return View();
        }
    }
}

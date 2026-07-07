using Microsoft.AspNetCore.Mvc;

namespace Internship1.Controllers
{
    public class BlogController : Controller
    {
        [HttpGet("tr/blog")]
        public IActionResult Index()
        {
            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace Internship1.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

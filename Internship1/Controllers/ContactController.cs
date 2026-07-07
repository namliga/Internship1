using Microsoft.AspNetCore.Mvc;

namespace Internship1.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

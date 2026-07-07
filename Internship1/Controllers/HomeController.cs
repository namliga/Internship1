using Internship1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Internship1.Controllers
{
    public class HomeController : Controller
    {

        [HttpGet("")]
        public IActionResult Root()
        {
            return RedirectToAction(nameof(Index));
        }

        [HttpGet("tr")]
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet("tr/hakkimizda")]
        public IActionResult About()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }



    }
}

using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Test_TeamCity_Website.Models;

namespace Test_TeamCity_Website.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger1;
        }

        public IActionResult Index()
        {
            string test = "make changes test again 2 - new branch";
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

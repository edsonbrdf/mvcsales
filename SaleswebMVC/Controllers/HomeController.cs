using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SaleswebMVC.Models;

namespace SaleswebMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index() //interface para todo resultado de uma ação
        {
            return View(); //objeto do tipo VIEW RESULT
        }

        public IActionResult Privacy()
        {
            ViewData["email"] = "test2@gmail.com";                
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

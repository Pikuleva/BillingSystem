using BillingSystem.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BillingSystem.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error(int statusCode)
        {
            if (statusCode == 404)
            {
                return View("Error404");
            }
            if (statusCode == 500)
            {
                return View("Error500");
            }

            return View();
        }
    }
}
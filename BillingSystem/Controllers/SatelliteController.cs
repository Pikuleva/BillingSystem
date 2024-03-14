using Microsoft.AspNetCore.Mvc;

namespace BillingSystem.Controllers
{
    public class SatelliteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

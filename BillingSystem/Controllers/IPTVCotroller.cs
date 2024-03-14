using Microsoft.AspNetCore.Mvc;

namespace BillingSystem.Controllers
{
    public class IPTVCotroller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

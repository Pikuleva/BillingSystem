using Microsoft.AspNetCore.Mvc;

namespace BillingSystem.Controllers
{
    public class InternetCotroller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace BillingSystem.Controllers
{
    public class TicketController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

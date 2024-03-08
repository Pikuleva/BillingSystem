using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using BillingSystem.Core.ViewModels;

namespace BillingSystem.Controllers
{
    [Authorize]
    public class ClientController : Controller
    {
        public async Task<IActionResult> Services()
        {
            var model = new ClientViewModel();
            return View(model);
        }
    }
}

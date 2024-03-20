using BillingSystem.Core.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BillingSystem.Controllers
{
    public class IPTVController : Controller
    {
        public async Task<IActionResult> Add()
        {
            var model = new IPTVFormModel();
            return View(model);
        }
    }
}

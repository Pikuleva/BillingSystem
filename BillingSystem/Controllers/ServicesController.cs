using BillingSystem.Core.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace BillingSystem.Controllers
{
    public class ServicesController : Controller
    {
        private readonly IServiceService serviceService;
        public ServicesController(IServiceService serviceService)
        {
            this.serviceService = serviceService;
        }
        public async Task<IActionResult> AllServices()
        {
            var model = await serviceService.ServicesViewModelsAsync();
            return View(model);
        }
       
    }
}

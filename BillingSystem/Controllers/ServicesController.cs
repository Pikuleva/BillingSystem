using BillingSystem.Core.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace BillingSystem.Controllers
{
    public class ServicesController : Controller
    {
        private readonly IServiceService serviceService;
        private readonly IClientService clientService;

        public ServicesController(IServiceService serviceService, IClientService clientService)
        {
            this.serviceService = serviceService;
            this.clientService = clientService;
        }
        public async Task<IActionResult> AllServices()
        {
            var model = await serviceService.ServicesViewModelsAsync();
            return View(model);
        }
       
    }
}

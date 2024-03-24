using BillingSystem.Core.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace BillingSystem.Controllers
{
    public class TicketController : Controller
    {
        private readonly IServiceService serviceService;
        private readonly IClientService clientService;

        public TicketController(IServiceService serviceService, IClientService clientService)
        {
            this.serviceService = serviceService;
            this.clientService = clientService;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}

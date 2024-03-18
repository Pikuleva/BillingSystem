using BillingSystem.Core.Contracts;
using BillingSystem.Core.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BillingSystem.Controllers
{
    public class InternetController : Controller
    {
        private readonly IInternetService internetService;
        public InternetController(IInternetService internetService)
        {
            this.internetService = internetService;
        }
        public IActionResult Add()
        {

            var model = new InternetFormModel();
            return View(model);
        }
    }
}

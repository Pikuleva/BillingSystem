using BillingSystem.Core.Contracts;
using BillingSystem.Core.Services;
using BillingSystem.Core.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BillingSystem.Controllers
{
    public class InternetController : Controller
    {
        private readonly IInternetService internetService;
        private readonly IClientService clientService;

        public InternetController(IInternetService internetService, IClientService clientService)
        {
            this.internetService = internetService;
            this.clientService = clientService;
        }
        [HttpGet]
        public async Task<IActionResult> Add()
        {

            var model = new InternetFormModel()
            {

                Product = await internetService.GetProductModelIdAsync(),
                TypeOfServiceModels = await internetService.GetTypeModel()
            };
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Add(InternetFormModel model, string civilNumber)
        {
            if (ModelState.IsValid == false)
            {
                model.Product = await internetService.GetProductModelIdAsync();
                model.TypeOfServiceModels = await internetService.GetTypeModel();
            }


            int newSatId = await internetService.CreateAsync(model, civilNumber);
            var client = await clientService.SearchClientAsync(civilNumber);
            int clientId = client.Id;
            return RedirectToAction(nameof(Details), new { clientId });
        }
        public async Task<IActionResult> Details(int id, InternetDetails model)
        {
            var modelNew = new InternetDetails();
            try
            {
                modelNew = await internetService.InternetServiceDetailsAsync(id);
            }
            catch (Exception)
            {
                if (model == null)
                {
                    ModelState.AddModelError(nameof(model), "Not valid");
                }

            }

            return View(modelNew);
        }


    }
}

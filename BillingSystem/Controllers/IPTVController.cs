using BillingSystem.Core.Contracts;
using BillingSystem.Core.Services;
using BillingSystem.Core.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BillingSystem.Controllers
{
    public class IPTVController : Controller
    {
        private readonly IIPTVService IPTVService;
        private readonly IClientService clientService;

        public IPTVController(IIPTVService IPTVService, IClientService clientService)
        {
            this.IPTVService = IPTVService;
            this.clientService = clientService;
        }
        public async Task<IActionResult> Details(int id, IPTVDetails model)
        {
            var modelNew = new IPTVDetails();
            try
            {
                modelNew = await IPTVService.IPTVServiceDetailsAsync(id);
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
        [HttpGet]
        public async Task<IActionResult> Add()
        {

            var model = new IPTVFormModel()
            {

                Product = await IPTVService.GetProductModelIdAsync(),
                TypeOfServiceModels = await IPTVService.GetTypeModel()
            };
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Add(IPTVFormModel model, string civilNumber)
        {
            if (ModelState.IsValid == false)
            {
                model.Product = await IPTVService.GetProductModelIdAsync();
                model.TypeOfServiceModels = await IPTVService.GetTypeModel();
            }


            int newSatId = await IPTVService.CreateAsync(model, civilNumber);
            var client = await clientService.SearchClientAsync(civilNumber);
            int clientId = client.Id;
            return RedirectToAction(nameof(Details), new { clientId });
        }
    }
}

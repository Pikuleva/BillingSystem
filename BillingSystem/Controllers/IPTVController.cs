using BillingSystem.Core.Contracts;
using BillingSystem.Core.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Routing;

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
       
        public async Task<IActionResult> Add(int clientId)
        {
            
            var model = new IPTVFormModel()
            {
                ClientId = clientId,
                Product = await IPTVService.GetProductModelIdAsync(),
                TypeOfServiceModels = await IPTVService.GetTypeModel()
            };
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Add(IPTVFormModel model)
        {
            if (ModelState.IsValid == false)
            {
                model.Product = await IPTVService.GetProductModelIdAsync();
                model.TypeOfServiceModels = await IPTVService.GetTypeModel();
                return View(model);
            }


            int newIptvId = await IPTVService.CreateAsync(model, model.Id);

                await clientService.AddIptvAsync(model.Id, newIptvId);
                    

            return RedirectToAction(nameof(Details), new { model.Id });
        }
    }
}

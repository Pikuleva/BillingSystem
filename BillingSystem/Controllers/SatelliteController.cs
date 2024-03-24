using BillingSystem.Core.Contracts;
using BillingSystem.Core.Services;
using BillingSystem.Core.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BillingSystem.Controllers
{
    public class SatelliteController : Controller
    {
        private readonly ISatellieteService satellieteService;
        private readonly IClientService clientService;
        public SatelliteController(ISatellieteService satellieteService, IClientService clientService)
        {
            this.satellieteService = satellieteService;
            this.clientService = clientService;
        }
        [HttpGet]
        public async Task<IActionResult> Details(int id, SatelliteDetails model)
        {
            var modelNew = new SatelliteDetails();
            try
            {
                modelNew = await satellieteService.SatelliteServiceDetailsAsync(id);
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

            var model = new SatelliteFormModel()
            {

                Product = await satellieteService.GetProductModelIdAsync(),
                
            };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Add(SatelliteFormModel model, string civilNumber)
        {
            
            //if (await satellieteService.ProductExistAsync(model.Id) == false)
            //{
            //    ModelState.AddModelError(nameof(model.Id), "");
            //}
            if (ModelState.IsValid == false)
            {
                model.Product = await satellieteService.GetProductModelIdAsync();
            }

            //int? clientId = await clientService.SearchClientAsync(User.Id());
            int newSatId = await satellieteService.CreateAsync(model,civilNumber);
           
            return RedirectToAction(nameof(Details), new { newSatId});
        }
    }
}

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
       //не взима ИД-то което му се подава от адд
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
                TypeOfServiceModels = await satellieteService.GetTypeModel()
            };
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Add(SatelliteFormModel model, int clientId)
        {
            if (ModelState.IsValid == false)
            {
                model.Product = await satellieteService.GetProductModelIdAsync();
                model.TypeOfServiceModels = await satellieteService.GetTypeModel();
                return View(model);
            }


            int newSatId = await satellieteService.CreateAsync(model);

            await clientService.AddSatelliteTvAsync(model.Id, newSatId);


            return RedirectToAction(nameof(Details), new { model.Id });
        }
    }
}

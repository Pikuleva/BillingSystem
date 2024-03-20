using BillingSystem.Core.Contracts;
using BillingSystem.Core.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BillingSystem.Controllers
{
    public class SatelliteController : Controller
    {
        private readonly ISatellieteService satellieteService;
        public SatelliteController(ISatellieteService satellieteService)
        {
            this.satellieteService = satellieteService;
        }
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
        public IActionResult Add()
        {

            var model = new ClientFormModel();
            return View(model);
        }
    }
}

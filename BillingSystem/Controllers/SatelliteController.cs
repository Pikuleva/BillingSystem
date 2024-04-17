using BillingSystem.Core.Contracts;
using BillingSystem.Core.Services;
using BillingSystem.Core.ViewModels;
using BillingSystem.Infrastructure.DataModels;
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

        public async Task<IActionResult> Add(int clientId)
        {
            var model = new SatelliteFormModel()
            {
                Product = await satellieteService.GetProductModelIdAsync(),
                TypeOfServiceModels = await satellieteService.GetTypeModel()
            };

            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Add(SatelliteFormModel model, int id)
        {
            var clientId = id;
            if (ModelState.IsValid == false)
            {
                model.Product = await satellieteService.GetProductModelIdAsync();
                model.TypeOfServiceModels = await satellieteService.GetTypeModel();
                return View(model);
            }

            model.ClientId = clientId;
            int newIptvId = await satellieteService.CreateAsync(model);

            await clientService.AddSatelliteTvAsync(model.ClientId, newIptvId);
            var modelView = new SatelliteDetails();
            modelView = await satellieteService.SatelliteServiceDetailsAsync(model.ClientId);

            return RedirectToAction(nameof(Details), modelView);
        }
        public async Task<IActionResult> Details(int id, IPTVDetails model)
        {
            if (id != 0 && model.ClientId != 0)
            {
                var modelNe = new SatelliteDetails();
                modelNe = await satellieteService.SatelliteServiceDetailsAsync(model.ClientId);
                return View(modelNe);
            }
            if (id != 0 && model.ClientId == 0)
            {
                var modelNe = new SatelliteDetails();
                modelNe = await satellieteService.SatelliteServiceDetailsAsync(id);
                return View(modelNe);
            }
            if (id == 0)
            {
                id = model.ClientId;
            }


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
        public async Task<IActionResult> Edit(int id)
        {
            if (await satellieteService.ExistAsync(id) == false)
            {
                return BadRequest();
            }

            var model = await satellieteService.GetSatelliteFormModelAsync(id);
            model.Product = await satellieteService.GetProductModelIdAsync();
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, SatelliteFormModel model)
        {
            if (id == 0)
            {
                id = model.Id;
            }
            if (await satellieteService.ExistAsync(id) == false)
            {
                return BadRequest();
            }
            if (model.SerialNumber < 5000000 || model.SerialNumber > 5999999)
            {
                ModelState.AddModelError(nameof(model.SerialNumber), "Невалиден сериен номер");
                model.Product = await satellieteService.GetProductModelIdAsync();
                return View(model);
            }
            if (model.Name.Length < 5 || model.Name.Length > 40)
            {
                ModelState.AddModelError(nameof(model.SerialNumber), "Невалидно име на устройството");
                model.Product = await satellieteService.GetProductModelIdAsync();
                return View(model);
            }
            await satellieteService.EditAsync(id, model);
            SatelliteDetails modelNew = new SatelliteDetails();
            modelNew = await satellieteService.SatelliteServiceDetailsAsync(model.ClientId);
            return RedirectToAction(nameof(Details), modelNew);
        }
    }
}

﻿using BillingSystem.Core.Contracts;
using BillingSystem.Core.Services;
using BillingSystem.Core.ViewModels;
using BillingSystem.Infrastructure.DataModels;
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
       
        [HttpGet]

        public async Task<IActionResult> Add(int clientId)
        {
            var model = new IPTVFormModel()
            {
                ActiveUntilDate = DateTime.UtcNow.AddMonths(1),
                Product = await IPTVService.GetProductModelIdAsync(),
                TypeOfServiceModels = await IPTVService.GetTypeModel()
            };
 
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Add(IPTVFormModel model,int id)
        {
            var clientId = id;
            if (ModelState.IsValid == false)
            {
                model.Product = await IPTVService.GetProductModelIdAsync();
                model.TypeOfServiceModels = await IPTVService.GetTypeModel();
                return View(model);
            }

            model.ClientId= clientId;
            int newIptvId = await IPTVService.CreateAsync(model);

            await clientService.AddIptvAsync(model.ClientId, newIptvId);
            var modelView = new IPTVDetails();
            modelView = await IPTVService.IPTVServiceDetailsAsync(model.ClientId);

            return RedirectToAction(nameof(Details), modelView);
        }
        public async Task<IActionResult> Details(int id, IPTVDetails model)
        {
            if (id != 0 && model.ClientId!=0)
            {
                var modelNe = new IPTVDetails();
                modelNe = await IPTVService.IPTVServiceDetailsAsync(model.ClientId);
                return View(modelNe);
            }
            if (id != 0 && model.ClientId == 0)
            {
                var modelNe = new IPTVDetails();
                modelNe = await IPTVService.IPTVServiceDetailsAsync(id);
                return View(modelNe);
            }
            if (id == 0)
            {
                id = model.ClientId;
            }
          
          
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
        public async Task<IActionResult> Edit(int id)
        {
            if (await IPTVService.ExistAsync(id) == false)
            {
                return BadRequest();
            }

            var model = await IPTVService.GetIPTVFormModelByIdAsync(id);
           model.Product = await IPTVService.GetProductModelIdAsync();
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, IPTVFormModel model)
        {
            if (id==0)
            {
                id = model.Id;
            }
            if (await IPTVService.ExistAsync(id) == false)
            {
                return BadRequest();
            }
            if (model.SerialNumber < 3000000 || model.SerialNumber > 3999999)
            {
                ModelState.AddModelError(nameof(model.SerialNumber), "Невалиден сериен номер");
                model.Product = await IPTVService.GetProductModelIdAsync();
                return View(model);
            }
            if (model.Name.Length<5 ||model.Name.Length>40)
            {
                ModelState.AddModelError(nameof(model.SerialNumber), "Невалидно име на устройството");
                model.Product = await IPTVService.GetProductModelIdAsync();
                return View(model);
            }

            await IPTVService.EditAsync(id, model);
            IPTVDetails modelNew = new IPTVDetails();
            modelNew = await IPTVService.IPTVServiceDetailsAsync(model.ClientId);
            return RedirectToAction(nameof(Details), modelNew);
        }
    }
}

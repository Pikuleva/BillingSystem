﻿using BillingSystem.Core.Contracts;
using BillingSystem.Core.ViewModels;
using BillingSystem.Infrastructure.DataModels;
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
        public async Task<IActionResult> Add(IPTVFormModel model)
        {
            if (ModelState.IsValid == false)
            {
                model.Product = await IPTVService.GetProductModelIdAsync();
                model.TypeOfServiceModels = await IPTVService.GetTypeModel();
                return View(model);
            }


            int newIptvId = await IPTVService.CreateAsync(model);

            await clientService.AddIptvAsync(model.Id, newIptvId);


            return RedirectToAction(nameof(Details), new { model.Id });
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

            if (await IPTVService.ExistAsync(id) == false)
            {
                return BadRequest();
            }

            await IPTVService.EditAsync(id, model);
            return RedirectToAction(nameof(Details), new { model.ClientId, model });
        }
    }
}

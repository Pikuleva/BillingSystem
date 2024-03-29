﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using BillingSystem.Core.ViewModels;
using BillingSystem.Core.Contracts;
using static BillingSystem.Core.Constants.MessageConstants;
using BillingSystem.Infrastructure.DataModels;

namespace BillingSystem.Controllers
{
    [Authorize]
    public class ClientController : Controller
    {
        private readonly IClientService clientService;
        private readonly ISatellieteService satellieteService;
        public ClientController(IClientService clientService, ISatellieteService satellieteService)
        {
            this.clientService = clientService;
            this.satellieteService = satellieteService;
        }

        public IActionResult Add()
        {

            var model = new ClientFormModel();
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Add(ClientFormModel model)
        {
            if (ModelState.IsValid == false)
            {
                return View(model);
            }

            if (await clientService.ExistByCivilNumberAsync(model.CivilNumber))
            {
                ModelState.AddModelError(nameof(model.CivilNumber), CivilExist);
            }
            if (clientService.IsValidEmail(model.Email))
            {
                ModelState.AddModelError(nameof(model.Email), EmailValidationMessage);
            }

            await clientService.CreateAsync(model);
            return RedirectToAction(nameof(HomeController.Index), "Home");
        }


        public IActionResult Search()
        {
            var model = new ClientDetail();
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Search(string civilNumber)
        {
            var model = new ClientDetail();
           
            if (await clientService.ExistAsync(model.Id) == false)
            {
                return NotFound();
            }
            try
            {
                model = await clientService.SearchClientAsync(civilNumber);
            }
            catch (Exception)
            {

                if (model == null)
                {
                    ModelState.AddModelError(nameof(model.CivilNumber), CivilNotValid);
                }
            }


            return RedirectToAction(nameof(Detail), model);
        }
        public async Task<IActionResult> Detail(int id, ClientDetail model)
        {
            var modelNew = new ClientDetail();
            try
            {
                modelNew = await clientService.SearchClientDetailAsyn(id);
            }
            catch (Exception)
            {
                if (model == null)
                {
                    ModelState.AddModelError(nameof(model.CivilNumber), CivilNotValid);
                }

            }

            return View(modelNew);
        }
        public async Task<IActionResult> Edit(int id)
        {
            if (await clientService.ExistAsync(id) == false)
            {
                return BadRequest();
            }

            var model = await clientService.GetClientFormModelByIdAsync(id);

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, ClientFormModel model)
        {
            if (await clientService.ExistAsync(id) == false)
            {
                return BadRequest();
            }

            await clientService.EditAsync(id, model);
            return RedirectToAction(nameof(Detail), new { id });
        }
    
    }
}

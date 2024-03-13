using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using BillingSystem.Core.ViewModels;
using BillingSystem.Core.Contracts;
using static BillingSystem.Core.Constants.MessageConstants;

namespace BillingSystem.Controllers
{
    [Authorize]
    public class ClientController : Controller
    {
        private readonly IClientService clientService;
        public ClientController(IClientService clientService)
        {
            this.clientService = clientService;
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

        
        public async Task<IActionResult> Search()
        {
            var model = new ClientDetail();
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Search(string civilNumber)
        {
            var model = await clientService.SearchClientAsync(civilNumber);
            return RedirectToAction(nameof(Detail), model);
        }
        public async Task<IActionResult> Detail(int id, ClientDetail model)
        {
            var modelNew = await clientService.SearchClientDetailAsyn(id);
            return View(modelNew);
        }

    }
}

using BillingSystem.Core.Contracts;
using BillingSystem.Core.Services;
using BillingSystem.Core.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BillingSystem.Controllers
{
    public class InternetController : Controller
    {
        private readonly IInternetService internetService;
        private readonly IClientService clientService;

        public InternetController(IInternetService internetService, IClientService clientService)
        {
            this.internetService = internetService;
            this.clientService = clientService;
        }
        public async Task<IActionResult> Add(int id)
        {
            if (await clientService.ExistAsync(id) == false)
            {
                return BadRequest();
            }

            var model = await clientService.GetClientFormModelByIdAsync(id);

            return View(model);
        }
        //public async Task<IActionResult> Details(int id, InternetDetails model)
        //{
        //    var modelNew = new InternetDetails();
        //    try
        //    {
        //        modelNew = await internetService.InternetServiceDetailsAsync(id);
        //    }
        //    catch (Exception)
        //    {
        //        if (model == null)
        //        {
        //            ModelState.AddModelError(nameof(model), "Not valid");
        //        }

        //    }

        //    return View(modelNew);
        //}


    }
}

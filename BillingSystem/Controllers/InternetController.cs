using BillingSystem.Core.Contracts;
using BillingSystem.Core.Services;
using BillingSystem.Core.ViewModels;
using Microsoft.AspNetCore.Mvc;
using static BillingSystem.Core.Constants.MessageConstants;

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
        [HttpGet]
        public async Task<IActionResult> Add()
        {

            var model = new InternetFormModel()
            {

                Product = await internetService.GetProductModelIdAsync(),
                TypeOfServiceModels = await internetService.GetTypeModel()
            };
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Add(InternetFormModel model)
        {
            if (ModelState.IsValid == false)
            {
                model.Product = await internetService.GetProductModelIdAsync();
                model.TypeOfServiceModels = await internetService.GetTypeModel();
                return View(model);
            }

            if (await internetService.IsExistMACAddress(model.RouterMACAdress))
            {
                ModelState.AddModelError(nameof(model.RouterMACAdress), MACAddressExist);
                model.Product = await internetService.GetProductModelIdAsync();
                model.TypeOfServiceModels = await internetService.GetTypeModel();
                return View(model);
            }

            int internetId = await internetService.CreateAsync(model);

            await clientService.AddInternetAsync(model.Id, internetId);


            return RedirectToAction(nameof(Details), new { model.Id });
        }
        public async Task<IActionResult> Details(int id, InternetDetails model)
        {
            var modelNew = new InternetDetails();
            try
            {
                modelNew = await internetService.InternetServiceDetailsAsync(id);
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


    }
}

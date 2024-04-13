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
        public async Task<IActionResult> Add(int clientId)
        {
            
            var model = new InternetFormModel()
            {

                Product = await internetService.GetProductModelIdAsync(),
                TypeOfServiceModels = await internetService.GetTypeModel()
            };
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Add(InternetFormModel model,int id)
        {
            var clientId = id;
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
            model.ClientId= clientId;
            int internetId = await internetService.CreateAsync(model);

            await clientService.AddInternetAsync(model.ClientId, internetId);
            var modelView = new InternetDetails();
            modelView = await internetService.InternetServiceDetailsAsync(model.ClientId);

            return RedirectToAction(nameof(Details), modelView);
        }
        public async Task<IActionResult> Details(int id,InternetDetails model)
        {
            if(id != 0 && model.ClientId != 0)
            {
                var modelNe = new InternetDetails();
                modelNe = await internetService.InternetServiceDetailsAsync(model.ClientId);
                return View(modelNe);
            }
            if (id != 0 && model.ClientId == 0)
            {
                var modelNe = new InternetDetails();
                modelNe = await internetService.InternetServiceDetailsAsync(id);
                return View(modelNe);
            }
            if (id == 0)
            {
                id = model.ClientId;
            }

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
        public async Task<IActionResult> Edit(int id)
        {
            if (await internetService.ExistAsync(id) == false)
            {

                return BadRequest();
            }

            var model = await internetService.GetInternetFormModelByIdAsync(id);
            model.Product = await internetService.GetProductModelIdAsync();
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, InternetFormModel model)
        {
           
            if (await internetService.ExistAsync(id) == false)
            {
                return BadRequest();
            }

            await internetService.EditAsync(id, model);
            InternetDetails modelNew = new InternetDetails();
            modelNew = await internetService.InternetServiceDetailsAsync(model.ClientId);
            return RedirectToAction(nameof(Details),  modelNew);
        }

    }
}

using BillingSystem.Core.Contracts;
using BillingSystem.Core.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BillingSystem.Controllers
{
    public class InternetController : Controller
    {
        private readonly IInternetService internetService;
        public InternetController(IInternetService internetService)
        {
            this.internetService = internetService;
        }
        [HttpGet]
        public async Task<IActionResult> Add()
        {
          
            var newIntServ = new InternetFormModel();
            
            return View(newIntServ);
        }
        [HttpPost]
        public async Task<IActionResult> Add(InternetFormModel model)
        {

            var newIntServ = new InternetFormModel();

            return View(newIntServ);
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

        //[HttpPost]
        //public async Task<IActionResult> AddAsync(InternetFormModel query)
        //{

        //    var modelView = internetService.CreateAsync(query);

        //    return View(modelView);
        //}
    }
}

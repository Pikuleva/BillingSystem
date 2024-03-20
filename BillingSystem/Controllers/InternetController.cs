using BillingSystem.Core.Contracts;
using BillingSystem.Core.ViewModels;
using BillingSystem.Infrastructure.DataModels.Constants;
using BillingSystem.Infrastructure.DataModels.Enumeration;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Build.Framework;
using System.Xml.Linq;

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

        //[HttpPost]
        //public async Task<IActionResult> AddAsync(InternetFormModel query)
        //{

        //    var modelView = internetService.CreateAsync(query);

        //    return View(modelView);
        //}
    }
}

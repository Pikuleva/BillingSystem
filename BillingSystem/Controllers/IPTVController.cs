using BillingSystem.Core.Contracts;
using BillingSystem.Core.ViewModels;
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
        //public async Task<IActionResult> Details(int id, IPTVDetails model)
        //{
        //    var modelNew = new IPTVDetails();
        //    try
        //    {
        //        modelNew = await IPTVService.IPTVServiceDetailsAsync(id);
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
        public IActionResult Add()
        {

            var model = new IPTVFormModel();
            return View(model);
        }
    }
}

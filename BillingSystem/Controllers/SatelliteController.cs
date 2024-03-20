﻿using BillingSystem.Core.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BillingSystem.Controllers
{
    public class SatelliteController : Controller
    {
        public async Task<IActionResult> Add()
        {
            var model = new SatelliteFormModel();
            return View(model);
        }
    }
}

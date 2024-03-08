﻿using BillingSystem.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillingSystem.Core.Contracts
{
    public interface IClientService
    {
        Task<bool> ExistByCivilNumberAsync(string civilNumber);

        Task CreateAsync(ClientFormModel model);
        bool IsValidEmail(string email);
    }
}
using BillingSystem.Core.Contracts;
using BillingSystem.Core.ViewModels;
using BillingSystem.Infrastructure.Common;
using BillingSystem.Infrastructure.DataModels;
using Microsoft.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using System.Xml.Linq;

namespace BillingSystem.Core.Services
{
    public class InternetServiceC : IInternetService
    {
        private readonly IRepository repository;
        public InternetServiceC(IRepository repository)
        {
            this.repository = repository;
        }

       
    }
}

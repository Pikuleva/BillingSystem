using BillingSystem.Core.Contracts;
using BillingSystem.Infrastructure.Common;

namespace BillingSystem.Core.Services
{
    public class InternetServiceC :IInternetService
    {
        private readonly IRepository repository;
        public InternetServiceC(IRepository repository)
        {
            this.repository = repository;
        }
    }
}

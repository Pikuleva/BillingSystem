using BillingSystem.Core.Contracts;
using BillingSystem.Infrastructure.Common;

namespace BillingSystem.Core.Services
{
    public class IPTVService : IIPTVService
    {
        private readonly IRepository repository;
        public IPTVService(IRepository repository)
        {
            this.repository = repository;
        }
    }
}

using BillingSystem.Core.Contracts;
using BillingSystem.Infrastructure.Common;

namespace BillingSystem.Core.Services
{
    public class SatelliteService : ISatellieteService
    {
        private readonly IRepository repository;
        public SatelliteService(IRepository repository)
        {
            this.repository = repository;
        }
    }
}

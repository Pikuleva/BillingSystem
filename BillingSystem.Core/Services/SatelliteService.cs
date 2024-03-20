using BillingSystem.Core.Contracts;
using BillingSystem.Core.ViewModels;
using BillingSystem.Infrastructure.Common;
using BillingSystem.Infrastructure.DataModels;
using Microsoft.EntityFrameworkCore;

namespace BillingSystem.Core.Services
{
    public class SatelliteService : ISatellieteService
    {
        private readonly IRepository repository;
        public SatelliteService(IRepository repository)
        {
            this.repository = repository;
        }

        public async Task<SatelliteDetails> SatelliteServiceDetailsAsync(int clientId)
        {
            var service = await repository.AllReadOnly<Client>()
                 .Where(c => c.Id == clientId)
                 .Select(c => c.SatelliteTvId)
                 .FirstAsync();

            if (service == null)
            {
                return null;
            }

            var client = await repository.AllReadOnly<Client>()
                .Where(c => c.Id == clientId)
                .Select(c => new SatelliteDetails()
                {

                    Id=c.SatelliteTV.Id,
                    NameOfService = c.SatelliteTV.Product.Name,
                    DeviceName = c.SatelliteTV.Name,
                    UntilDate = c.SatelliteTV.ActiveUntilDate,
                    Price = c.SatelliteTV.Product.Price,
                    SerialNumber = c.SatelliteTV.SerialNumber

                })
                .FirstAsync();


            return client;
        }
    }
}

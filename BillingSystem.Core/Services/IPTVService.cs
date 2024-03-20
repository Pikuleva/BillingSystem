using BillingSystem.Core.Contracts;
using BillingSystem.Core.ViewModels;
using BillingSystem.Infrastructure.Common;
using BillingSystem.Infrastructure.DataModels;
using Microsoft.EntityFrameworkCore;

namespace BillingSystem.Core.Services
{
    public class IPTVService : IIPTVService
    {
        private readonly IRepository repository;
        public IPTVService(IRepository repository)
        {
            this.repository = repository;
        }

        public async Task<IPTVDetails> IPTVServiceDetailsAsync(int clientId)
        {
            var service = await repository.AllReadOnly<Client>()
                .Where(c => c.Id == clientId)
                .Select(c => c.IPTVId)
                .FirstAsync();

            if (service == null)
            {
                return null;
            }

            var client = await repository.AllReadOnly<Client>()
                .Where(c => c.Id == clientId)
                .Select(c => new IPTVDetails()
                {
                    Id=c.IPTV.Id,
                    NameOfService=c.IPTV.Product.Name,
                    DeviceName=c.IPTV.Name,
                    UntilDate=c.IPTV.ActiveUntilDate,
                    Price=c.IPTV.Product.Price,
                    SerialNumber=c.IPTV.SerialNumber

                })
                .FirstAsync();


            return client;
        }
    }
}

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

        public async Task<int> CreateAsync(IPTVFormModel model)
        {
            IPTV iPTVFormModel = new IPTV()
            {
                Id = model.Id,
                Name = model.Name,
                SerialNumber = model.SerialNumber,
                ActiveUntilDate = model.ActiveUntilDate,
                ProductId = model.ProductModelId,


            };

            await repository.AddAsync(iPTVFormModel);
            await repository.SaveChangesAsync();

            return iPTVFormModel.Id;
        }

        public async Task<IEnumerable<ProductModel>> GetProductModelIdAsync()
        {
            return await repository.AllReadOnly<Product>()
                 .Where(p => p.TypeId == 3)
                 .Select(p => new ProductModel()
                 {
                     Id = p.Id,
                     Name = p.Name,
                     Price = p.Price

                 })
                 .ToListAsync();
        }

        public async Task<IEnumerable<TypeOfServiceModel>> GetTypeModel()
        {
            return await repository.AllReadOnly<TypeOfService>()
               .Select(t => new TypeOfServiceModel()
               {
                   Id = t.Id,
                   Name = t.Name
               })
               .ToListAsync();
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

            IPTVDetails iptvModel = await repository.AllReadOnly<Client>()
                .Where(c => c.Id == clientId)
                .Select(c => new IPTVDetails()
                {
                    Id = c.IPTV.Id,
                    NameOfService=c.IPTV.Product.Name,
                    DeviceName=c.IPTV.Name,
                    UntilDate=c.IPTV.ActiveUntilDate,
                    Price=c.IPTV.Product.Price,
                    SerialNumber=c.IPTV.SerialNumber

                })
                .FirstAsync();


            return iptvModel;
        }
    }
}

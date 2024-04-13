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
                Name = model.Name,
                SerialNumber = model.SerialNumber,
                ActiveUntilDate = model.ActiveUntilDate,
                ProductId = model.ProductModelId
               
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
                    ActiveUntilDate=c.IPTV.ActiveUntilDate,
                    Price=c.IPTV.Product.Price,
                    SerialNumber=c.IPTV.SerialNumber,
                    ClientId=c.Id
                })
                .FirstAsync();


            return iptvModel;
        }
        public async Task<bool> ExistAsync(int id)
        {
            return await repository.AllReadOnly<IPTV>()
                .AnyAsync(h => h.Id == id);
        }
        public async Task<IPTVFormModel> GetIPTVFormModelByIdAsync(int id)
        {
            var iptv = await repository.AllReadOnly<IPTV>()
                .Where(h => h.Id == id)
                .Select(h => new IPTVFormModel()
                {
                   Id=id,
                    Name=h.Name,
                    ActiveUntilDate = h.ActiveUntilDate,
                    SerialNumber = h.SerialNumber,
                    ProductModelId = h.ProductId,
                    ClientId =h.ClientId
                })
                .FirstAsync();

            return iptv;
        }
        public async Task EditAsync(int iptvId, IPTVFormModel model)
        {
            var iptv = await repository.GetByIdAsync<IPTV>(iptvId);

            if (iptv != null)
            {
                iptv.Id = iptvId;
                iptv.Name = model.Name;
                iptv.ActiveUntilDate = model.ActiveUntilDate;
                iptv.SerialNumber = model.SerialNumber;
                iptv.ProductId = model.ProductModelId;
            }
            await repository.SaveChangesAsync();
        }
    }
}

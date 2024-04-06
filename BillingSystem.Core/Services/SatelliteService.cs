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

    

        public async Task<IEnumerable<ProductModel>> GetProductModelIdAsync()
        {
           return await repository.AllReadOnly<Product>()
                .Where(p=>p.TypeId==2)
                .Select(p=>new ProductModel()
                {
                    Id = p.Id,
                    Name = p.Name,
                    Price = p.Price
                    
                })
                .ToListAsync();
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

            var satTv = await repository.AllReadOnly<SatelliteTV>()
                .Where(s => s.Id == service)
                .Select(s => new SatelliteDetails()
                {
                    Id = s.Id,
                    SerialNumber = s.SerialNumber,
                    NameOfService = s.Product.Name,
                    Price = s.Product.Price,
                    UntilDate = DateTime.Now
                })
                .FirstAsync();
            return satTv;
        }
        public async Task<int> CreateAsync(SatelliteFormModel model)
        {
            SatelliteTV satTV = new SatelliteTV()
            {
                Name = model.Name,
                SerialNumber= model.SerialNumber,
                ActiveUntilDate = model.ActiveUntilDate,
                ProductId=model.ProductModelId,

         
            };
                      
            await repository.AddAsync(satTV);
            await repository.SaveChangesAsync();

            return satTV.Id;
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

       
    }
}

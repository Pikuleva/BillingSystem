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

        public async Task EditAsync(int satId, SatelliteFormModel model)
        {
            var satelliteTV = await repository.GetByIdAsync<SatelliteTV>(satId);
    
            if (satelliteTV != null)
            {
                satelliteTV.Id = satId;
                satelliteTV.Name = model.Name;
                satelliteTV.ActiveUntilDate = model.ActiveUntilDate;
                satelliteTV.SerialNumber = model.SerialNumber;
                satelliteTV.ProductId = model.ProductModelId;
                model.ClientId= satelliteTV.ClientId;
            }
            await repository.SaveChangesAsync();
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

            SatelliteDetails satTv = await repository.AllReadOnly<SatelliteTV>()
                .Where(s => s.Id == service)
                .Select(s => new SatelliteDetails()
                {
                    Id = s.Id,
                    DeviceName=s.Name,
                    SerialNumber = s.SerialNumber,
                    NameOfService = s.Product.Name,
                    Price = s.Product.Price,
                    ActiveUntilDate=s.ActiveUntilDate,
                    ClientId=clientId
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
        public async Task<SatelliteFormModel> GetSatelliteFormModelAsync(int id)
        {
            var sat = await repository.AllReadOnly<SatelliteTV>()
                .Where(h => h.Id == id)
                .Select(h => new SatelliteFormModel()
                {
                    Id = id,
                    Name = h.Name,
                    ActiveUntilDate = h.ActiveUntilDate,
                    SerialNumber = h.SerialNumber,
                    ProductModelId = h.ProductId,
                    ClientId = h.ClientId,
                    TypeOfServiceId = h.Product.TypeId

                })
                .FirstAsync();

            return sat;
        }

        public async Task<bool> ExistAsync(int id)
        {
            return await repository.AllReadOnly<SatelliteTV>()
                .AnyAsync(h => h.Id == id);
        }
    }
}

using BillingSystem.Core.Contracts;
using BillingSystem.Core.ViewModels;
using BillingSystem.Infrastructure.Common;
using BillingSystem.Infrastructure.DataModels;
using Microsoft.CodeAnalysis;
using Microsoft.EntityFrameworkCore;

namespace BillingSystem.Core.Services
{
    public class InternetServiceC : IInternetService
    {
        private readonly IRepository repository;
        public InternetServiceC(IRepository repository)
        {
            this.repository = repository;
        }

        public async Task<int> CreateAsync(InternetFormModel model, string civilNumber)
        {
            InternetService internet = new InternetService()
            {
                Name = model.Name.ToString(),
                ActiveUntilDate = model.ActiveUntilDate,
                ProductId = model.ProductModelId,
                RouterMACAdress = model.RouterMACAdress

            };
            Client client = await repository.AllReadOnly<Client>()
                .Where(c => c.CivilNumber == civilNumber)
                .FirstAsync();


            await repository.AddAsync(internet);
            await repository.SaveChangesAsync();

            return internet.Id;
        }

        public async Task<IEnumerable<ProductModel>> GetProductModelIdAsync()
        {
            return await repository.AllReadOnly<Product>()
                .Where(p => p.TypeId == 1)
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

        public async Task<InternetDetails> InternetServiceDetailsAsync(int clientId)
        {
            var service = await repository.AllReadOnly<Client>()
                .Where(c=>c.Id==clientId)
                .Select(c=>c.InternetServiceId)
                .FirstAsync();
           
            if (service == null)
            {
                return null;
            }

            var client = await repository.AllReadOnly<Client>()
                .Where(c => c.Id == clientId)
                .Select(c => new InternetDetails()
                { 
                    Id=c.InternetService.Id,
                    Name = c.InternetService.Name,
                    RouterMAC = c.InternetService.RouterMACAdress,
                    UntilDate = c.InternetService.ActiveUntilDate,
                    Price = c.InternetService.Product.Price
                })
                .FirstAsync();
          

            return client;
        }


    }
}

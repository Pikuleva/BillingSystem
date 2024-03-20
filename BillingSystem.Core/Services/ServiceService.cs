using BillingSystem.Core.Contracts;
using BillingSystem.Core.ViewModels;
using BillingSystem.Infrastructure.Common;
using BillingSystem.Infrastructure.DataModels;
using Microsoft.EntityFrameworkCore;

namespace BillingSystem.Core.Services
{
    public class ServiceService : IServiceService
    {
        private readonly IRepository repository;
        public ServiceService(IRepository repository)
        {
            this.repository = repository;
        }

        public async Task<IEnumerable<decimal>> AllPricesAsync()
        {
            return  await repository.AllReadOnly<Product>()
                .Select(h => h.Price)
                .ToListAsync();
        }

        public async Task<IEnumerable<string>> AllProductNamesAsync()
        {
            return await repository.AllReadOnly<Product>()
          .Select(h => h.Name)
          .ToListAsync();
        }

        public async Task<IEnumerable<string>> AllTypeOfServiceNameAsync()
        {
            return await repository.AllReadOnly<TypeOfService>()
           .Select(h => h.Name)
           .ToListAsync();
        }

        public async Task<ServicesViewModel> ServicesViewModelsAsync()
        {
            var model = new ServicesViewModel()
            {
                Names = new List<string>(),
                PricePerMonth = new List<decimal> (),
                ProductsNames=new List<string>(),
            };
           model.Names= await AllTypeOfServiceNameAsync();
            model.PricePerMonth = await AllPricesAsync();
            model.ProductsNames = await AllProductNamesAsync();

            return model;
        }
    }
}

using BillingSystem.Core.ViewModels;
using BillingSystem.Infrastructure.DataModels.Enumeration;

namespace BillingSystem.Core.Contracts
{
    public interface IInternetService
    {
        Task<InternetDetails> InternetServiceDetailsAsync(int clientId);


        Task<IEnumerable<ProductModel>> GetProductModelIdAsync();


        Task<int> CreateAsync(InternetFormModel model, string civilNumber);
        Task<IEnumerable<TypeOfServiceModel>> GetTypeModel();
    }
}

using BillingSystem.Core.ViewModels;

namespace BillingSystem.Core.Contracts
{
    public interface IInternetService
    {
        Task<InternetDetails> InternetServiceDetailsAsync(int clientId);


        Task<IEnumerable<ProductModel>> GetProductModelIdAsync();

        Task<bool> IsExistMACAddress(string macAddress);
        Task<int> CreateAsync(InternetFormModel model);
        Task<IEnumerable<TypeOfServiceModel>> GetTypeModel();
    }
}

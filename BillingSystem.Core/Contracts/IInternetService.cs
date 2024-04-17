using BillingSystem.Core.ViewModels;

namespace BillingSystem.Core.Contracts
{
    public interface IInternetService
    {
        Task<InternetDetails> InternetServiceDetailsAsync(int clientId);
        Task EditAsync(int internetId, InternetFormModel model);
        Task<bool> ExistAsync(int id);
        Task<IEnumerable<ProductModel>> GetProductModelIdAsync();
        Task<InternetFormModel> GetInternetFormModelByIdAsync(int id);
        Task<bool> IsExistMACAddress(string macAddress);
        Task<int> CreateAsync(InternetFormModel model);
        Task<IEnumerable<TypeOfServiceModel>> GetTypeModel();
        Task<bool> IsValidMacAddressAsync(string MACAddress);
    }
}

using BillingSystem.Core.ViewModels;

namespace BillingSystem.Core.Contracts
{
    public interface IIPTVService
    {
        Task<IPTVDetails> IPTVServiceDetailsAsync(int clientId);
  

        Task<IEnumerable<ProductModel>> GetProductModelIdAsync();


        Task<int> CreateAsync(IPTVFormModel model);
        Task<IEnumerable<TypeOfServiceModel>> GetTypeModel();
    }
}

using BillingSystem.Core.ViewModels;

namespace BillingSystem.Core.Contracts
{
    public interface IIPTVService
    {
        Task<IPTVDetails> IPTVServiceDetailsAsync(int clientId);

        Task<bool> ExistAsync(int id);
        Task<IEnumerable<ProductModel>> GetProductModelIdAsync();
        Task EditAsync(int iptvId, IPTVFormModel model);
        Task<IPTVFormModel> GetIPTVFormModelByIdAsync(int id);
        Task<int> CreateAsync(IPTVFormModel model);
        Task<IEnumerable<TypeOfServiceModel>> GetTypeModel();
    }
}

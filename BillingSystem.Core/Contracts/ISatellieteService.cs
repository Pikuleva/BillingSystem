using BillingSystem.Core.ViewModels;

namespace BillingSystem.Core.Contracts
{
    public interface ISatellieteService
    {
        Task<SatelliteDetails> SatelliteServiceDetailsAsync(int clientId);
        Task<SatelliteFormModel> GetSatelliteFormModelAsync(int id);
        Task<IEnumerable<ProductModel>> GetProductModelIdAsync();
        Task<bool> ExistAsync(int id);
        Task EditAsync(int satId, SatelliteFormModel model);
        Task<int> CreateAsync(SatelliteFormModel model);
        Task<IEnumerable<TypeOfServiceModel>> GetTypeModel();
       


    }
}

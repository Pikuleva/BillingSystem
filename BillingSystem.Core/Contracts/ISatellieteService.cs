using BillingSystem.Core.ViewModels;

namespace BillingSystem.Core.Contracts
{
    public interface ISatellieteService
    {
        Task<SatelliteDetails> SatelliteServiceDetailsAsync(int clientId);

        Task<IEnumerable<ProductModel>> GetProductModelIdAsync();

       
        Task<int> CreateAsync(SatelliteFormModel model);
        Task<IEnumerable<TypeOfServiceModel>> GetTypeModel();
       


    }
}

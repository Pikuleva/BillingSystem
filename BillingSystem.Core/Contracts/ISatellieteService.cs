using BillingSystem.Core.ViewModels;

namespace BillingSystem.Core.Contracts
{
    public interface ISatellieteService
    {
        Task<SatelliteDetails> SatelliteServiceDetailsAsync(int clientId);

        Task<IEnumerable<ProductModel>> GetProductModelIdAsync();

        Task<bool> ProductExistAsync(int id);
        Task<int> CreateAsync(SatelliteFormModel model,string civilNumber);
        Task<SatelliteDetails> GetSatelliteTVByIdAsync(int id);
       
    }
}

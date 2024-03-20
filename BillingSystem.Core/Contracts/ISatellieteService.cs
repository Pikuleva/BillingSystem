using BillingSystem.Core.ViewModels;

namespace BillingSystem.Core.Contracts
{
    public interface ISatellieteService
    {
        Task<SatelliteDetails> SatelliteServiceDetailsAsync(int clientId);

    }
}

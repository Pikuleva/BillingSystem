using BillingSystem.Core.ViewModels;

namespace BillingSystem.Core.Contracts
{
    public interface IClientService
    {
        Task<bool> ExistByCivilNumberAsync(string civilNumber);
        Task CreateAsync(ClientFormModel model);
        Task<bool> IsValidEmail(string email);
        Task<bool> IsValidCivilNumber(string civilNumber);
      
        Task<bool> PhoneExist(string phoneNumber); 
        Task<ClientDetail?> SearchClientAsync(string civilNumber);
        Task<ClientDetail> SearchClientDetailsAsync(int id);
        Task EditAsync(int clientId, ClientFormModel model);
        Task<bool> ExistAsync(int id);
        Task<ClientFormModel> GetClientFormModelByIdAsync(int id);
        Task AddIptvAsync(int clientId,int iptvId);
        Task AddSatelliteTvAsync(int clientId, int satId);
        Task AddInternetAsync(int clientId, int internetId);
    }
}

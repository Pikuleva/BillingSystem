using BillingSystem.Core.ViewModels;
using BillingSystem.Infrastructure.DataModels;

namespace BillingSystem.Core.Contracts
{
    public interface IClientService
    {
        Task<bool> ExistByCivilNumberAsync(string civilNumber);

        Task CreateAsync(ClientFormModel model);
        bool IsValidEmail(string email);

        Task<ClientDetail?> SearchClientAsync(string civilNumber);
        Task<ClientDetail> SearchClientDetailAsyn(int id);
        Task EditAsync(int clientId, ClientFormModel model);
        Task<bool> ExistAsync(int id);

        Task<ClientFormModel> GetClientFormModelByIdAsync(int id);

        Task<bool> GetSatTvServiceASyc(int id);

        Task AddIptvAsync(int clientId,int iptvId);
        Task AddSatelliteTvAsync(int clientId, int satId);
        Task AddInternetAsync(int clientId, int internetId);

    }
}

using BillingSystem.Core.ViewModels;

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
    }
}

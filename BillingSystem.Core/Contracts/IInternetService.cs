using BillingSystem.Core.ViewModels;
using BillingSystem.Infrastructure.DataModels.Enumeration;

namespace BillingSystem.Core.Contracts
{
    public interface IInternetService
    {
        Task CreateAsync(InternetFormModel model);
        Task<InternetFormModel> CreateInternetFormModel(string macAddress, InternetProductsWithPrice name,DateTime untilDate);
        //Task<InternetFormModel> AddNameToInternetProduct(string name);
        Task<InternetFormModel> AddPropToModel(string name, decimal price, string mac, DateTime date);
        Task<ClientFormModel> GetClientByIdAsync(int clientId);
    }
}

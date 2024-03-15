using BillingSystem.Core.ViewModels;

namespace BillingSystem.Core.Contracts
{
    public interface IServiceService
    {
        Task<ServicesViewModel> ServicesViewModelsAsync();
        Task<IEnumerable<string>> AllTypeOfServiceNameAsync();
        Task<IEnumerable<string>> AllProductNamesAsync ();
        Task<IEnumerable<decimal>> AllPricesAsync();
    }
}

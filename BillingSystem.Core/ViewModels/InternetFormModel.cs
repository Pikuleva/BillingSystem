using BillingSystem.Infrastructure.DataModels;
using BillingSystem.Infrastructure.DataModels.Enumeration;

namespace BillingSystem.Core.ViewModels
{
    public class InternetFormModel
    {
        public int Id { get; set; }
      
        public DateTime UntilDate {  get; set; }
        public string RouterMACAdress { get; set; } = string.Empty;
      
        public string InternetProducts { get; set; }
        public decimal Price { get; set; }
    }
}

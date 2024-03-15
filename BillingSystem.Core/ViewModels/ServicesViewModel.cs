using BillingSystem.Infrastructure.DataModels;
using System.ComponentModel.DataAnnotations;

namespace BillingSystem.Core.ViewModels
{
    public class ServicesViewModel
    {
        public IEnumerable<string> Names { get; set; } = null!;
        public IEnumerable<string> ProductsNames {  get; set; } = null!;

        [Display(Name = "Price per montch")]
        public IEnumerable<decimal> PricePerMonth { get; set; } = null!;
      
    }
}

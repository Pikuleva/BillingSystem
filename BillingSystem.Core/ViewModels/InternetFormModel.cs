using BillingSystem.Core.Enum;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static BillingSystem.Infrastructure.DataModels.Constants.ValidationEntity.ClientContract;
using static BillingSystem.Infrastructure.DataModels.Constants.ValidationEntity.ServiceConst;

namespace BillingSystem.Core.ViewModels
{
    public class InternetFormModel
    {
        public int Id { get; set; }

      
        public DateTime UntilDate {  get; set; }
        [Required]
        [Display(Name="MAC адрес")]
        public string RouterMACAdress { get; set; } = string.Empty;
        [Required]
        [Comment("Name of service. Include internet speed")]
        [Display(Name = "Име на услугата")]
        public InternetProductsWithPrice Name { get; set; } 

        [Required]
        [Comment("Until which date the service is active")]
        [Display(Name = "Плащане до:")]
        public DateTime ActiveUntilDate { get; set; }


        [Display(Name = "Вид на услугата")]
        public int TypeOfServiceId { get; set; }

        [Display(Name = "План")]
        public int ProductModelId { get; set; }



        public IEnumerable<ProductModel> Product { get; set; } = new List<ProductModel>();

        public IEnumerable<TypeOfServiceModel> TypeOfServiceModels { get; set; } = new List<TypeOfServiceModel>();

        public int ClientId { get; set; }

    }
}

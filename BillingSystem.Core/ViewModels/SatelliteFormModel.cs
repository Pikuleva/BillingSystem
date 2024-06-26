﻿using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static BillingSystem.Infrastructure.DataModels.Constants.ValidationEntity.ServiceConst;
using static BillingSystem.Core.Constants.MessageConstants;

namespace BillingSystem.Core.ViewModels
{
    public class SatelliteFormModel
    {
        public int Id { get; set; }

        [Required]
        [Range(5000000, 5999999)]
        [Display(Name = "Сериен номер")]
        public int SerialNumber { get; set; }

        [Required]
        [Comment("Device model name")]
        [Display(Name = "Модел на устройството")]
        [StringLength(NameMaxLength,MinimumLength =NameMinLength,ErrorMessage = NameOfDevice)]
        public string Name { get; set; } = string.Empty;

        [Required]
        [Comment("Until which date the service is active")]
        [Display(Name = "Плащане до:")]
        public DateTime ActiveUntilDate { get; set; }

        [Display(Name = "Вид на услугата")]
        [Range(1,int.MaxValue)]
        public int TypeOfServiceId { get; set; }

        [Display(Name = "Пакет ТВ услуга")]
        public int ProductModelId { get; set; }

        public int ClientId { get; set; }
     
        public IEnumerable<ProductModel> Product { get; set; } = new List<ProductModel>();

        public IEnumerable<TypeOfServiceModel> TypeOfServiceModels { get; set; } = new List<TypeOfServiceModel>();

        
    }
}

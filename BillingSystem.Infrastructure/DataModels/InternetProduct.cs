using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static BillingSystem.Infrastructure.DataModels.Constants.ValidationEntity.InternetServiceConst;

namespace BillingSystem.Infrastructure.DataModels
{
    /// <summary>
    /// Интернет пакет
    /// </summary>
    [Comment("Internet product")]
    public class InternetProduct
    {
        /// <summary>
        /// Идентификатор на услугата
        /// </summary>
        [Key]
        [Comment("Internet product identificator")]
        public int Id { get; set; }

        /// <summary>
        /// Име на услугата - спрямо скоростта на връзката
        /// </summary>
        [Required]
        [MaxLength(NameMaxLength)]
        [Comment("Name of internet service")]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Цена на услугата
        /// </summary>
        [Required]
        [Comment("Price of internet service")]
        public decimal Price { get; set; }

    }
}

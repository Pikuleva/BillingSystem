using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static BillingSystem.Infrastructure.DataModels.Constants.ValidationEntity.InternetServiceConst;

namespace BillingSystem.Infrastructure.DataModels
{
    /// <summary>
    /// Пакет интерактивна телевизия
    /// </summary>
    [Comment("IPTV product")]
    public class IPTVProduct
    {
        /// <summary>
        /// Идентификатор на услугата
        /// </summary>
        [Key]
        [Comment("IPTV identificator")]
        public int Id { get; set; }

        /// <summary>
        /// Име на услугата
        /// </summary>
        [Required]
        [MaxLength(NameMaxLength)]
        [Comment("Name of the service")]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Цена на услугата
        /// </summary>
        [Required]
        [Comment("Price of television service")]
        public decimal Price { get; set; }
    }
}

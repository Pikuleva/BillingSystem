using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static BillingSystem.Infrastructure.DataModels.Constants.ValidationEntity.ServiceConst;

namespace BillingSystem.Infrastructure.DataModels
{
    /// <summary>
    /// Пакет интерактивна телевизия
    /// </summary>
    [Comment("IPTV product")]
    public class Product
    {
        /// <summary>
        /// Идентификатор на услугата
        /// </summary>
        [Key]
        [Comment("Identificator")]
        public int Id { get; set; }

        /// <summary>
        /// Име на услугата
        /// </summary>
        [Required]
        [MaxLength(NameMaxLength)]
        [Comment("Name of the service")]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Вид на услугата Интернет или Телевизия
        /// </summary>
        [Required]
        [MaxLength(NameMaxLength)]
        public string Type { get; set; } = string.Empty;
        /// <summary>
        /// Цена на услугата
        /// </summary>
        [Required]
        [Comment("Price of  service")]
        public decimal Price { get; set; }
    }
}

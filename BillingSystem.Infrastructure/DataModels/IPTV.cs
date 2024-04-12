using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BillingSystem.Infrastructure.DataModels
{
    /// <summary>
    /// Интерактиван телевизия
    /// </summary>
    [Comment("Interactive television")]
    public class IPTV
    {
        /// <summary>
        /// Идентификато на приемника
        /// </summary>
        [Key]
        [Comment("Interactive television identificator")]
        public int Id { get; set; }

        /// <summary>
        /// Сериен номер на приемника
        /// </summary>
        [Required]
        [Range(3000000, 3999999)]
        [Comment("Serial number of device")]
        public int SerialNumber { get; set; }

        /// <summary>
        /// Дата до която услугата е заплатена и активна
        /// </summary>
        [Required]
        [Comment("Until which date the service is active")]
        public DateTime ActiveUntilDate { get; set; }

        /// <summary>
        /// Модел на приемника
        /// </summary>
        [Required]
        [Comment("Device model name")]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Услугата е активна/неактивна спрямо това, дали е заплатена
        /// </summary>
        [Required]
        [Comment("The service is paid/unpaid")]
        public bool IsActive { get; set; }


        /// <summary>
        /// Начислен пакет спрямо абонамента
        /// </summary>
        [Required]
        [Comment("TV packet")]
        [ForeignKey(nameof(ProductId))]
        public Product Product { get; set; } = null!;
        /// <summary>
        /// Идентификатор на ТВ услугата
        /// </summary>
        [Required]
        [Comment("Television product Identificator")]
        public int ProductId { get; set; }
        public Client Client { get; set; } = null!;
        public int ClientId { get; set; }

    }
}
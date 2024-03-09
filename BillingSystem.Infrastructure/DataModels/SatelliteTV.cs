using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace BillingSystem.Infrastructure.DataModels
{
    /// <summary>
    /// Сателитна телевизия
    /// </summary>
    [Comment("Satellite televiision")]
    public class SatelliteTV
    {
        /// <summary>
        /// Идентификатор на сателитния приемник
        /// </summary>
        [Key]
        [Comment("Satellite television identificator")]
        public int Id { get; set; }

        /// <summary>
        /// Сериен номер на приемника
        /// </summary>
        [Required]
        [Range(5000000, 5999999)]
        [Comment("Satellite device serial number")]
        public int SerialNumber { get; set; }

        /// <summary>
        /// Модел на приемника
        /// </summary>
        [Required]
        [Comment("Model of satelite device")]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Дата до която услугата е заплатена и активна
        /// </summary>
        [Required]
        [Comment("Until which date the service is active")]
        public DateTime ActiveUntilDate { get; set; }


        /// <summary>
        /// Начислен пакет спрямо абонамента
        /// </summary>
        [Required]
        [Comment("TV packet")]
        public Product Packet { get; set; } = null!;

       
    }
}

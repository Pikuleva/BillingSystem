using BillingSystem.Infrastructure.DataModels.Constants;
using BillingSystem.Infrastructure.DataModels.Enumeration;
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
        [Range(5000000,5999999)]
        [Comment("Satellite device serial number")]
        public int SerialNumber { get; set; }

        /// <summary>
        /// Модел на приемника
        /// </summary>
        [Required]
        [Comment("Model of satelite device")]
        public SatModel Name { get; set; }

        /// <summary>
        /// Начислени пакети спрямо абонамента
        /// </summary>
        public ICollection<TVPackets> Packets { get; set; } = new List<TVPackets>();

        /// <summary>
        /// Цена на услугата 
        /// </summary>
        public List<Price.TVPrice> Price { get; set; } = new List<Price.TVPrice> { };
    }
}

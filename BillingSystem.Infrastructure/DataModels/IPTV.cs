using BillingSystem.Infrastructure.DataModels.Constants;
using BillingSystem.Infrastructure.DataModels.Enumeration;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

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
        [Range(3000000,3999999)]
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
        public IPTVModelName Name { get; set; }

        /// <summary>
        /// Какви пакети са включени в абонамета
        /// </summary>
        public ICollection<TVPackets> Packets { get; set; } = new List<TVPackets>();

        /// <summary>
        /// Цена на услугата 
        /// </summary>
        public List<Price.TVPrice> Price { get; set; }= new List<Price.TVPrice>();
    }
}

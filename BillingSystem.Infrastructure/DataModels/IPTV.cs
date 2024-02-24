using BillingSystem.Infrastructure.DataModels.Enumeration;
using System.ComponentModel.DataAnnotations;
using static BillingSystem.Infrastructure.DataModels.Constants.ValidationEntity.IPTVConst;

namespace BillingSystem.Infrastructure.DataModels
{
    /// <summary>
    /// Интерактиван телевизия
    /// </summary>
    public class IPTV
    {
        /// <summary>
        /// Идентификато на приемника
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Сериен номер на приемника
        /// </summary>
        [Required]
        [Range(3000000,3999999)]
        public int SerialNumber { get; set; }

        /// <summary>
        /// Модел на приемника
        /// </summary>
        [Required]
        public IPTVModelName Name { get; set; }

        /// <summary>
        /// Какви пакети са включени в абонамета
        /// </summary>
        public ICollection<TVPackets> Packets { get; set; } = new List<TVPackets>();

        /// <summary>
        /// Цена на услугата 
        /// </summary>
        public List<Price.TVPrice> Price { get; set; }
    }
}

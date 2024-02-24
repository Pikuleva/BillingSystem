using BillingSystem.Infrastructure.DataModels.Enumeration;
using System.ComponentModel.DataAnnotations;

namespace BillingSystem.Infrastructure.DataModels
{
    /// <summary>
    /// Сателитна телевизия
    /// </summary>
    public class SateliteTv
    {
        /// <summary>
        /// Идентификатор на сателитния приемник
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Сериен номер на приемника
        /// </summary>
        [Required]
        [Range(5000000,5999999)]
        public int SerialNumber { get; set; }

        /// <summary>
        /// Модел на приемника
        /// </summary>
        [Required]
        public SatModel Name { get; set; }

        /// <summary>
        /// Начислени пакети спрямо абонамента
        /// </summary>
        public ICollection<TVPackets> Packets { get; set; } = new List<TVPackets>();

        /// <summary>
        /// Цена на услугата 
        /// </summary>
        public List<Price.TVPrice> Price { get; set; }
    }
}

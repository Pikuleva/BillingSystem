using BillingSystem.Infrastructure.DataModels.Constants;
using BillingSystem.Infrastructure.DataModels.Enumeration;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static BillingSystem.Infrastructure.DataModels.Constants.ValidationEntity.InternetServiceConst;

namespace BillingSystem.Infrastructure.DataModels
{
    /// <summary>
    /// Интернет услуга
    /// </summary>
    [Comment("Internet service")]
    public class InternetService
    {
        /// <summary>
        /// Идентификато на услугата
        /// </summary>
        [Key]
        [Comment("Internet service identificator")]
        public int Id { get; set; }

        /// <summary>
        /// Име на услугата - спрямо пакета, който използва. В името задължително трябва да е включен параметър за скоростта на интернет връзката
        /// </summary>
        [Required]
        [MaxLength(NameMaxLength)]
        [Comment("Name of service. Include internet speed")]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// MAC адрес на клиентското устройство до което се доставя услуга
        /// </summary>
        [Required]
        [MaxLength(MACLength)]
        [Comment("MAC address client device")]
        public string RouterMACAdress { get; set; } = string.Empty;

        /// <summary>
        /// Вида(скоростта) на интернет услугата
        /// </summary>
        [Required]
        [Comment("Internet package")]
        public InternetProduct Product { get; set; }

        /// <summary>
        /// Услугата е активна/неактивна спрямо това, дали е заплатена
        /// </summary>
        [Required]
        [Comment("The service is paid/unpaid")]
        public bool IsActive { get; set; }

        /// <summary>
        /// Дата до която услугата е заплатена и активна
        /// </summary>
        [Required]
        [Comment("Until which date the service is active")]
        public DateTime ActiveUntilDate { get; set; }

        /// <summary>
        /// Цена на услугата
        /// </summary>  
        [Required]
        [Comment("Price of the service")]
        [Column(TypeName ="decimal(18,2)")]
        public decimal Price { get; set; }

    }
}

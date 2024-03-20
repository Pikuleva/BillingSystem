using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static BillingSystem.Infrastructure.DataModels.Constants.ValidationEntity.ServiceConst;

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
        [ForeignKey(nameof(ProductId))]
        public Product Product { get; set; } = null!;

        /// <summary>
        /// Идентификатор на интернет услугата
        /// </summary>
        [Required]
        [Comment("Internet product Identificator")]
        public int ProductId { get; set; }

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

       
    }
}

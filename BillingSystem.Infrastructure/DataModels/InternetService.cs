using BillingSystem.Infrastructure.DataModels.Enumeration;
using System.ComponentModel.DataAnnotations;
using static BillingSystem.Infrastructure.DataModels.Constants.ValidationEntity.InternetServiceConst;

namespace BillingSystem.Infrastructure.DataModels
{
    /// <summary>
    /// Интернет услуга
    /// </summary>
    public class InternetService
    {
        /// <summary>
        /// Идентификато на услугата
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Име на услугата - спрямо пакета, който използва. В името задължително трябва да е включен параметър за скоростта на интернет връзката
        /// </summary>
        [Required]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; }=string.Empty;

        /// <summary>
        /// MAC адрес на клиентското устройство до което се доставя услуга
        /// </summary>
        [Required]
        [MaxLength(MACLength)]
        public string RouterMACAdress { get; set; } = string.Empty;

        /// <summary>
        /// Вида(скоростта) на интернет услугата
        /// </summary>
        [Required]
        public InternetProduct Product { get; set; }

        /// <summary>
        /// Услугата е активна/неактивна спрямо това, дали е заплатена
        /// </summary>
        [Required]
        public bool IsActive { get; set; }

        /// <summary>
        /// Цена на услугата
        /// </summary>
        public Price.InternetPrices Prices { get; set; } 

    }
}

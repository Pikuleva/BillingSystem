using System.ComponentModel.DataAnnotations;
using System.Configuration;
using static BillingSystem.Infrastructure.DataModels.Constants.ValidationEntity.ClientContract;

namespace BillingSystem.Infrastructure.DataModels
{
    /// <summary>
    /// Договор на клиента с включените услуги към него
    /// </summary>
    public class ClientContract
    {
        /// <summary>
        /// Идентификатор към клиентски договор
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Номер на клиентски договор
        /// </summary>
        [Required]
        [Range(100000,199999)]
        public int ContractNumber { get; set; }
        /// <summary>
        /// Първо име на клиента
        /// </summary>
        [Required]
        [MaxLength(FirstNameMaxLength)]
        public string FirstName { get; set; } = string.Empty;
        /// <summary>
        /// Бащино име на клиента
        /// </summary>     
        [MaxLength(MiddleNameMaxLength)]
        public string MiddleName { get; set; } = string.Empty;

        /// <summary>
        /// Фамилия на клиента
        /// </summary>
        [Required]
        [MaxLength(LastNameMaxLength)]
        public string LastName { get; set; }=string.Empty;

        /// <summary>
        /// ЕГН на клиента
        /// </summary>

        [Required]
        [RegexStringValidator(RegexCivilNumber)]
        public int CivilNumber { get; set; }

        /// <summary>
        /// Адрес на клиента - записва се мястото на което се ползва услугата
        /// </summary>
        [Required]
        [MaxLength(CityMaxLength)]
        public string City { get; set; } = string.Empty;

        /// <summary>
        /// Име на улица
        /// </summary>
        [MaxLength(StreetNameMaxLength)]
        public string StreetName { get; set; }= string.Empty;

        /// <summary>
        /// Номер на улица
        /// </summary>
        [MaxLength(StreetNameMaxLength)]
        public string StreetNumber { get; set; } = string.Empty;

        /// <summary>
        /// Мобилен телефон на клиента
        /// </summary>
        [Required]
        [RegexStringValidator(RegexValidationPhoneNumber)]
        public int PhoneNumber { get; set; }

        /// <summary>
        /// Електроенен адрес на клиента
        /// </summary>
        [RegexStringValidator(RegexValidationEmail)]
        public string Email { get; set; } = string.Empty;

        /// <summary>
        /// Интернет услуги към договора
        /// </summary>
        public ICollection<InternetService?> InternetService { get; set; } = new List<InternetService?>();

        /// <summary>
        /// IPTV услуга към договора
        /// </summary>  
        public ICollection<IPTV?> IPTV { get; set; } = new List<IPTV?>();

        /// <summary>
        /// Сателитна телевизия към договора
        /// </summary>    
        public ICollection<SateliteTv?> SateliteTv { get; set; } = new List<SateliteTv?>();

    }
}

using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Configuration;
using static BillingSystem.Infrastructure.DataModels.Constants.ValidationEntity.ClientContract;

namespace BillingSystem.Infrastructure.DataModels
{
    /// <summary>
    /// Договор на клиента с включените услуги към него
    /// </summary>
    [Comment("Client contract")]
    public class Client
    {
        /// <summary>
        /// Идентификатор към клиентски договор
        /// </summary>
        [Key]
        [Comment("Client identificator")]
        public int Id { get; set; }

        /// <summary>
        /// Номер на клиентски договор
        /// </summary>
        [Required]
        [Range(100000, 199999)]
        [Comment("Contract number")]
        public int ContractNumber { get; set; }
        /// <summary>
        /// Първо име на клиента
        /// </summary>
        [Required]
        [MaxLength(FirstNameMaxLength)]
        [Comment("Client first name")]
        public string FirstName { get; set; } = string.Empty;
        /// <summary>
        /// Бащино име на клиента
        /// </summary>     
        [MaxLength(MiddleNameMaxLength)]
        [Comment("Client middle name")]
        public string MiddleName { get; set; } = string.Empty;

        /// <summary>
        /// Фамилия на клиента
        /// </summary>
        [Required]
        [MaxLength(LastNameMaxLength)]
        [Comment("Client last name")]
        public string LastName { get; set; } = string.Empty;

        /// <summary>
        /// ЕГН на клиента
        /// </summary>

        [Required]
        [RegexStringValidator(RegexCivilNumber)]
        [Comment("Client persanal number")]
        public int CivilNumber { get; set; }

        /// <summary>
        /// Адрес на клиента - записва се мястото на което се ползва услугата
        /// </summary>
        [Required]
        [MaxLength(CityMaxLength)]
        [Comment("City where customer uses the service")]
        public string City { get; set; } = string.Empty;

        /// <summary>
        /// Име на улица
        /// </summary>
        [MaxLength(StreetNameMaxLength)]
        [Comment("Street where customer uses the service")]
        public string StreetName { get; set; } = string.Empty;

        /// <summary>
        /// Номер на улица
        /// </summary>
        [MaxLength(StreetNameMaxLength)]
        [Comment("StreetNumber where customer uses the service")]
        public string StreetNumber { get; set; } = string.Empty;

        /// <summary>
        /// Мобилен телефон на клиента
        /// </summary>
        [Required]
        [RegexStringValidator(RegexValidationPhoneNumber)]
        [Comment("Client phone number")]
        public int PhoneNumber { get; set; }

        /// <summary>
        /// Електроенен адрес на клиента
        /// </summary>
        [RegexStringValidator(RegexValidationEmail)]
        [Comment("Client Email address")]
        public string Email { get; set; } = string.Empty;

  
        public IEnumerable<Ticket> Tickets { get; set; } = new List<Ticket>();
        public IEnumerable<IPTV> IPTVs { get; set; } = new List<IPTV>();
        public IEnumerable<InternetService> InternetServices { get; set; } = new List<InternetService>();
        public IEnumerable<SatelliteTV> SatteliteTVs { get; set; } = new List<SatelliteTV>();
    }
}

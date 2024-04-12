using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        [MaxLength(CivilLength)]
        [Comment("Client persanal number")]
        public string CivilNumber { get; set; } = string.Empty;

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
        [MaxLength(ClientPhoneNumberMaxLength)]
        [Comment("Client phone number")]
        public string PhoneNumber { get; set; } = string.Empty;

        /// <summary>
        /// Електроенен адрес на клиента
        /// </summary>
        [RegexStringValidator(RegexValidationEmail)]
        [Comment("Client Email address")]
        public string Email { get; set; } = string.Empty;

        /// <summary>
        /// Идентификатор на интернет услуга
        /// </summary>
        [Comment("Internet Service Id")]
        public int? InternetServiceId { get; set; }

        /// <summary>
        /// Интернет услуга
        /// </summary>
        [Comment("Internet Service")]
        [ForeignKey(nameof(InternetServiceId))]
        public InternetService? InternetService { get; set; }

        /// <summary>
        /// Идентификато на интерактиван телевизия
        /// </summary>
        [Comment("IPTV Id")]
        public int? IPTVId { get; set; }

        /// <summary>
        /// Интерактивна телевизия
        /// </summary>
        [Comment("IPTV service")]
        [ForeignKey(nameof(IPTVId))]
        public IPTV? IPTV { get; set; }

        /// <summary>
        /// Идентификатор на сателитна телевизия
        /// </summary>
        [Comment("Satellite Id")]
        public int? SatelliteTvId { get; set; }

        /// <summary>
        /// Сателитна телевизия
        /// </summary>
        [Comment("Satellite TV")]
        [ForeignKey(nameof(SatelliteTvId))]
        public SatelliteTV? SatelliteTV { get; set; }

        public IEnumerable<Ticket> Tickets { get; set; } = new List<Ticket>();
       
    }
}

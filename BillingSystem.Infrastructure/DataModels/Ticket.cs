using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static BillingSystem.Infrastructure.DataModels.Constants.ValidationEntity.TicketConst;

namespace BillingSystem.Infrastructure.DataModels
{
    /// <summary>
    /// Заявки за аварии 
    /// </summary>
    [Comment("Service tickets")]
    public class Ticket
    {
        /// <summary>
        /// Идентификатор на заявката
        /// </summary>
        [Key]
        [Comment("Ticket identificator")]
        public int Id { get; set; }

        /// <summary>
        /// Номер на договор към който се пуска заявката
        /// </summary>
        [Required]
        [Range(100000, 199999)]
        [Comment("Client contract number")]
        public int ClientContractNumber { get; set; }

        /// <summary>
        /// Дата на създаване на заявката
        /// </summary>
        [Required]
        [Comment("Date of created ticket")]
        public DateTime CreatedOn { get; set; }

        /// <summary>
        /// Описание на техническия проблем, поради който липсва услугата
        /// </summary>
        [Required]
        [MaxLength(DescriptionMaxLength)]
        [Comment("Problem description")]
        public string Description { get; set; } = string.Empty;
        /// <summary>
        /// Град в който се ползва услугата
        /// </summary>
        [Required]
        [MaxLength(CityMaxLength)]
        [Comment("City")]
        public string City { get; set; }= string.Empty;

        /// <summary>
        /// Име на улицата където е услугата
        /// </summary>
        [Comment("Street")]
        public string  Street { get; set; } = string.Empty;

        /// <summary>
        /// Номер 
        /// </summary>
        [Comment("StreetNumber")]
        public string StreetNumber { get; set; } = string.Empty;

        /// <summary>
        /// Заявката е изпълнена/отворена
        /// </summary>
        [Required]
        [Comment("Is complited ticket")]
        public bool IsComplited { get; set; }


    }
}

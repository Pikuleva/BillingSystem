using System.ComponentModel.DataAnnotations;
using static BillingSystem.Infrastructure.DataModels.Constants.ValidationEntity.TicketConst;

namespace BillingSystem.Infrastructure.DataModels
{
    /// <summary>
    /// Заявки за аварии 
    /// </summary>
    public class Ticket
    {
        /// <summary>
        /// Идентификатор на заявката
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Номер на договор към който се пуска заявката
        /// </summary>
        [Required]
        [Range(100000, 199999)]
        public int ClientContractNumber { get; set; }

        /// <summary>
        /// Дата на създаване на заявката
        /// </summary>
        [Required]
        public DateTime CreatedOn { get; set; }

        /// <summary>
        /// Описание на техническия проблем, поради който липсва услугата
        /// </summary>
        [Required]
        [MaxLength(DescriptionMaxLength)]
        public string Description { get; set; } = string.Empty;
        /// <summary>
        /// Град в който се ползва услугата
        /// </summary>
        [Required]
        [MaxLength(CityMaxLength)]
        public string City { get; set; }= string.Empty;

        /// <summary>
        /// Име на улицата където е услугата
        /// </summary>
        public string  Street { get; set; } = string.Empty;

        /// <summary>
        /// Номер 
        /// </summary>
        public string StreetNumber { get; set; } = string.Empty;

        /// <summary>
        /// Заявката е изпълнена/отворена
        /// </summary>
        [Required]
        public bool IsComplited { get; set; }

    }
}

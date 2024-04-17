using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static BillingSystem.Infrastructure.DataModels.Constants.ValidationEntity.ServiceConst;

namespace BillingSystem.Infrastructure.DataModels
{
    /// <summary>
    /// Вид на услугата
    /// </summary>
    [Comment("Type of service")]
    public class TypeOfService
    {
        /// <summary>
        /// Идентификато на вида
        /// </summary>
        [Key]
        [Comment("Type of service identificator")]
        public int Id { get; set; }

        /// <summary>
        /// Вид на услугата
        /// </summary>
        [Required]
        [MaxLength(NameMaxLength)]
        [Comment("Name of type")]
        public string Name { get; set; } = string.Empty;
    }
}

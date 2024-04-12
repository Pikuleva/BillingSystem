using System.ComponentModel.DataAnnotations;

namespace BillingSystem.Infrastructure.DataModels
{
    /// <summary>
    /// Вид на услугата
    /// </summary>
    public class TypeOfService
    {
        /// <summary>
        /// Идентификато на вида
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Вид на услугата
        /// </summary>
        public string Name { get; set; } = string.Empty;
    }
}

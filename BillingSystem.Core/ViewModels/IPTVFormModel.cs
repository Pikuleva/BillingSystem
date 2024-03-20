using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BillingSystem.Core.ViewModels
{
    public class IPTVFormModel
    {
        public int Id { get; set; }

        [Required]
        [Range(3000000, 3999999)]
        [Comment("Serial number of device")]
        public int SerialNumber { get; set; }

        [Required]
        [Comment("Device model name")]
        public string Name { get; set; } = string.Empty;

        [Required]
        [Comment("Until which date the service is active")]
        public DateTime ActiveUntilDate { get; set; }

        public int ProductModelId { get; set; }
        [ForeignKey(nameof(ProductModelId))]
        //price and name
        public ProductModel Product { get; set; } = null!;
    }
}

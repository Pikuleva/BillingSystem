﻿using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BillingSystem.Core.ViewModels
{
    public class SatelliteFormModel
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
        public string CivilNumber { get; set; } = string.Empty;
        public int ProductModelId { get; set; }
        [ForeignKey(nameof(ProductModelId))]


        public IEnumerable<ProductModel> Product { get; set; } = new List<ProductModel>();

        public int ClientId { get; set; }
        
    }
}

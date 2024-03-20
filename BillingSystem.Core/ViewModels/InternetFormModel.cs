﻿using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BillingSystem.Core.ViewModels
{
    public class InternetFormModel
    {
        public int Id { get; set; }

        [Required]
        [Comment("Device model name")]
        public string Name { get; set; } = string.Empty;

        public DateTime UntilDate {  get; set; }
        public string RouterMACAdress { get; set; } = string.Empty;

        public int ProductModelId { get; set; }
        [ForeignKey(nameof(ProductModelId))]
        //price and name
        public ProductModel Product { get; set; } = null!;
    }
}

using System.ComponentModel.DataAnnotations;

namespace BillingSystem.Infrastructure.DataModels
{
    public class TypeOfService
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
    }
}

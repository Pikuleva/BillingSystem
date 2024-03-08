using BillingSystem.Infrastructure.DataModels;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Configuration;
using static BillingSystem.Infrastructure.DataModels.Constants.ValidationEntity.ClientContract;
using static BillingSystem.Core.Constants.MessageConstants;

namespace BillingSystem.Core.ViewModels
{
    public class ClientFormModel
    {
        [Required]
        public int LastId { get; set; }

        [Required]
        [Range(100000, 199999)]
        public int ContractNumber {  get; set; }

        [Required(ErrorMessage = RequiredMessage)]
        [StringLength(FirstNameMaxLength,MinimumLength =FirstNameMinLength,ErrorMessage = StringLengthMessage)]
        public string FirstName { get; set; } = string.Empty;
 
        [StringLength(MiddleNameMaxLength, MinimumLength =MiddleNameMinLength,ErrorMessage = StringLengthMessage)]
        public string MiddleName { get; set; } = string.Empty;

        [Required(ErrorMessage =RequiredMessage)]
        [StringLength(LastNameMaxLength,MinimumLength =LastNameMinLength, ErrorMessage =StringLengthMessage)]
        public string LastName { get; set; } = string.Empty;

        [Required(ErrorMessage = RequiredMessage)]
        [RegexStringValidator(RegexCivilNumber)]
        public int CivilNumber { get; set; }

        [Required(ErrorMessage = RequiredMessage)]
        [StringLength(CityMaxLength,MinimumLength =CityMinLength, ErrorMessage =StringLengthMessage)]
        public string City { get; set; } = string.Empty;

        [StringLength(StreetNameMaxLength,MinimumLength =StreetNameMinLength, ErrorMessage = StringLengthMessage)]
        public string StreetName { get; set; } = string.Empty;

        [StringLength(StreetNumberMaxLength,MinimumLength =StreetNumberMaxLength,ErrorMessage =StringLengthMessage)]
        public string StreetNumber { get; set; } = string.Empty;

        [Required(ErrorMessage = RequiredMessage)]
        [RegexStringValidator(RegexValidationPhoneNumber)]
        public int PhoneNumber { get; set; }

        [RegexStringValidator(RegexValidationEmail)]
        public string Email { get; set; } = string.Empty;
    }
}

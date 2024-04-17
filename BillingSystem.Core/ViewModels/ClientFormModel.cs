using System.ComponentModel.DataAnnotations;
using System.Configuration;
using static BillingSystem.Core.Constants.MessageConstants;
using static BillingSystem.Infrastructure.DataModels.Constants.ValidationEntity.ClientContract;

namespace BillingSystem.Core.ViewModels
{
    public class ClientFormModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = RequiredMessage)]
        [StringLength(FirstNameMaxLength,MinimumLength =FirstNameMinLength,ErrorMessage = StringLengthMessage)]
        public string FirstName { get; set; } = string.Empty;
 
        [StringLength(MiddleNameMaxLength, MinimumLength =MiddleNameMinLength,ErrorMessage = StringLengthMessage)]
        public string MiddleName { get; set; } = string.Empty;

        [Required(ErrorMessage =RequiredMessage)]
        [StringLength(LastNameMaxLength,MinimumLength =LastNameMinLength, ErrorMessage =StringLengthMessage)]
        public string LastName { get; set; } = string.Empty;

        [Required(ErrorMessage = RequiredMessage)]
        [RegularExpression("^\\d{10}$", ErrorMessage = CivilNumberValidation)]
        public string CivilNumber { get; set; } = string.Empty;

        [Required(ErrorMessage = RequiredMessage)]
        [StringLength(CityMaxLength,MinimumLength =CityMinLength, ErrorMessage =StringLengthMessage)]
        public string City { get; set; } = string.Empty;

        [StringLength(StreetNameMaxLength,MinimumLength =StreetNameMinLength, ErrorMessage = StringLengthMessage)]
        public string StreetName { get; set; } = string.Empty;

        [Required(ErrorMessage = RequiredMessage)]
        [StringLength(StreetNumberMaxLength,MinimumLength =StreetNumberMinLength,ErrorMessage =StringLengthMessage)]
        public string StreetNumber { get; set; } = string.Empty;

        [Required(ErrorMessage = RequiredMessage)]
        [StringLength(ClientPhoneNumberMaxLength, MinimumLength = ClientPhoneNumberMinLength, ErrorMessage = StringLengthMessage)]
        [RegexStringValidator(RegexValidationPhoneNumber)]
        public string PhoneNumber { get; set; } = string.Empty;

        [RegularExpression(RegexValidationEmail, ErrorMessage = EmailValidationMessage)]
        [StringLength(EmailMaxLength,MinimumLength =EmailMinLength,ErrorMessage =EmailValidationMessage)]
        public string Email { get; set; } = string.Empty;

       
        public InternetFormModel? InternetFormModel { get; set; }

        public IPTVFormModel? IPTVFormModel { get; set; }

        public SatelliteFormModel? SatelliteFormModel { get; set; }
    }
}

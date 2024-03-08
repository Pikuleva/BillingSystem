﻿using System.ComponentModel.DataAnnotations;
using System.Configuration;
using static BillingSystem.Core.Constants.MessageConstants;
using static BillingSystem.Infrastructure.DataModels.Constants.ValidationEntity.ClientContract;

namespace BillingSystem.Core.ViewModels
{
    public class ClientFormModel
    {
        [Required]
        public int LastId { get; set; }


        [Required(ErrorMessage = RequiredMessage)]
        [StringLength(FirstNameMaxLength,MinimumLength =FirstNameMinLength,ErrorMessage = StringLengthMessage)]
        public string FirstName { get; set; } = string.Empty;
 
        [StringLength(MiddleNameMaxLength, MinimumLength =MiddleNameMinLength,ErrorMessage = StringLengthMessage)]
        public string MiddleName { get; set; } = string.Empty;

        [Required(ErrorMessage =RequiredMessage)]
        [StringLength(LastNameMaxLength,MinimumLength =LastNameMinLength, ErrorMessage =StringLengthMessage)]
        public string LastName { get; set; } = string.Empty;

        [Required(ErrorMessage = RequiredMessage)]
        [RegularExpression("^\\d{10}$", ErrorMessage = "Valid Learner Number must be supplied")]
        public string CivilNumber { get; set; } = string.Empty;

        [Required(ErrorMessage = RequiredMessage)]
        [StringLength(CityMaxLength,MinimumLength =CityMinLength, ErrorMessage =StringLengthMessage)]
        public string City { get; set; } = string.Empty;

        [StringLength(StreetNameMaxLength,MinimumLength =StreetNameMinLength, ErrorMessage = StringLengthMessage)]
        public string StreetName { get; set; } = string.Empty;

        [StringLength(StreetNumberMaxLength,MinimumLength =StreetNumberMinLength,ErrorMessage =StringLengthMessage)]
        public string StreetNumber { get; set; } = string.Empty;

        [Required(ErrorMessage = RequiredMessage)]
        [StringLength(ClientPhoneNumberMaxLength, MinimumLength = ClientPhoneNumberMinLength, ErrorMessage = StringLengthMessage)]
        [RegexStringValidator(RegexValidationPhoneNumber)]
        public string PhoneNumber { get; set; } = string.Empty;

        [RegexStringValidator(RegexValidationEmail)]
        public string Email { get; set; } = string.Empty;
    }
}
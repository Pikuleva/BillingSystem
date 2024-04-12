namespace BillingSystem.Core.Constants
{
    public static class MessageConstants
    {
        public const string RequiredMessage = "Полето {0} е задължително";

        public const string StringLengthMessage = "Полето {0} трябва да бъде между {2} и {1} цимвола";

        public const string CivilExist = "The {0} exist";

        public const string EmailValidationMessage = "Невалиден Email адрес";
        public const string InvalidCivilNumber = "Невалидно ЕГН";

        public const string CivilNumberValidation = "ЕГН-то трябва да съдържа 10 цифри";
        public const string CivilNotValid = "Полето {0} не е валидно или клиента не същствува";

        public const string MACAddressExist = "MAC адреса вече съществува";

       
    }
}

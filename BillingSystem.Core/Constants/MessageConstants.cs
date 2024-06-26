﻿namespace BillingSystem.Core.Constants
{
    public static class MessageConstants
    {
        public const string RequiredMessage = "Полето е задължително";
        public const string NameOfDevice = "Полето трябва да бъде между {2} и {1} символа";
        public const string SerialNumberSatellite = "Сериийния номер трябва да бъде между 5000000 и 5999999";
        public const string StringLengthMessage = "Полето трябва да бъде между {2} и {1} символа";

        public const string CivilExist = "Клиент с това ЕГН вече съществува в системата";

        public const string EmailValidationMessage = "Невалиден Email адрес";
        public const string InvalidCivilNumber = "Невалидно ЕГН";

        public const string CivilNumberValidation = "ЕГН-то трябва да съдържа 10 цифри";
        public const string CivilNotValid = "Полето не е валидно или клиента не същствува";

        public const string MACAddressExist = "MAC адреса вече съществува";
        public const string InvaliMACAddress = "Невалиден MAC адрес";
        public const string PhoneExist = "Този телефонен номер вече съществува в системата";


       
    }
}

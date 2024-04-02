namespace BillingSystem.Infrastructure.DataModels.Constants
{
    public static class ValidationEntity
    {
        public static class ClientContract
        {
            public const int ContractLength = 10;

            

            public const int FirstNameMinLength = 3;
            public const int FirstNameMaxLength = 15;

            public const int MiddleNameMinLength = 3;   
            public const int MiddleNameMaxLength = 15;

            public const int LastNameMinLength = 3;
            public const int LastNameMaxLength = 15;

            public const int CityMinLength = 2;
            public const int CityMaxLength = 20;

            public const int StreetNameMinLength = 2;
            public const int StreetNameMaxLength = 25;

            public const int StreetNumberMinLength = 1;
            public const int StreetNumberMaxLength = 6;

            public const int EmailMinLength = 6;
            public const int EmailMaxLength = 35;

            public const int ClientPhoneNumberMinLength = 7;
            public const int ClientPhoneNumberMaxLength = 15;

            public const int CivilLength = 10;

            public const string RegexValidationEmail = "^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\\.[a-zA-Z]{2,}$\r\n";

            public const string RegexValidationPhoneNumber = "^[0 - 9]{10}$";

            public const string RegexCivilNumber = "^\\d{10}$";

        }
        public static class ServiceConst
        {
            public const int MACLength = 17;

            public const int NameMinLength = 5;
            public const int NameMaxLength = 40;
        }
        public static class IPTVConst
        {
            public const int IPTVNameMinLength = 2;
            public const int IPTVNameMaxLength = 15;
        }
        public class TicketConst
        {
            public const int DescriptionMinLength = 5;
            public const int DescriptionMaxLength = 1500;

            public const int CityMinLength = 2;
            public const int CityMaxLength = 20;
        }
    }
}


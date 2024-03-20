namespace BillingSystem.Core.ViewModels
{
    public class ClientDetail
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string MiddleName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Address {  get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string PhoneNumber {get; set; } = string.Empty;
        public string CivilNumber {get; set; } = string.Empty;

        public InternetDetails? InternetDetails { get; set; }
        public SatelliteDetails? SatelliteDetails {  get; set; }
        public IPTVDetails? IPTVDetails { get; set; }

    }
}

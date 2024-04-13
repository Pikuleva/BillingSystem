namespace BillingSystem.Core.ViewModels
{
    public class IPTVDetails
    {
        public int Id { get; set; }
        public string NameOfService { get; set; }
        public string DeviceName { get; set; }
        public DateTime ActiveUntilDate { get; set; }
        public decimal Price { get; set; }
        public int SerialNumber { get; set; }
    }
}

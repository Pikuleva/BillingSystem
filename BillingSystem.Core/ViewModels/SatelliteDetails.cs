namespace BillingSystem.Core.ViewModels
{
    public class SatelliteDetails
    {
        public int Id { get; set; }

        public string NameOfService { get; set; }
        public string DeviceName { get; set; }
        public DateTime ActiveUntilDate { get; set; }
        public decimal Price { get; set; }
        public int SerialNumber { get; set; }
        public int ClientId { get; set; }
    }
}

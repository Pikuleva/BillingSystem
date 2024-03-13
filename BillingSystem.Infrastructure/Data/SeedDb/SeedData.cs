using BillingSystem.Infrastructure.DataModels;
using Microsoft.AspNetCore.Identity;
using NuGet.Packaging.Signing;

namespace BillingSystem.Infrastructure.Data.SeedDb
{
    public class SeedData
    {
        public IdentityUser ClientUser { get; set; }
        public IdentityUser CashierUser { get; set; }
        public IdentityUser SupportUser { get; set; }
        public Product InternetProduct25Mbps { get; set; }
        public Product InternetProduct50Mbps { get; set; }
        public Product InternetProduct75Mbps { get; set; }
        public Product InternetProduct100Mbps { get; set; }
        public Product TvBase { get; set; }
        public Product TvFilms { get; set; }
        public Product TvSport { get; set; }
        public Product TvPopularsciene { get; set; }
        public Product TvKids { get; set; }
        public Product TvErotic { get; set; }
        public Product TvMusic { get; set; }
        public TypeOfService InternetType { get; set; }
        public TypeOfService SatTvType { get; set; }
        public TypeOfService IPTVType { get; set; }
    }
}


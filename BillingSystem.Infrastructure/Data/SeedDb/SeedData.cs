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
        public Product TvBaseSat { get; set; }
        public Product TvFilmsSat { get; set; }
        public Product TvSportSat { get; set; }
        public Product TvPopularscieneSat { get; set; }
        public Product TvKidsSat { get; set; }
        public Product TvEroticSat { get; set; }
        public Product TvBaseIPTV { get; set; }
        public Product TvFilmsIPTV { get; set; }
        public Product TvSportIPTV { get; set; }
        public Product TvPopularscieneIPTV { get; set; }
        public Product TvKidsIPTV { get; set; }
        public Product TvEroticIPTV { get; set; }
        public TypeOfService InternetType { get; set; }
        public TypeOfService SatTvType { get; set; }
        public TypeOfService IPTVType { get; set; }
        public Client Client { get; set; }
        public InternetService InternetService { get; set; }
        public SatelliteTV SatelliteTV { get; set; }
        public IPTV IPTV { get; set; }

        public SeedData()
        {
            SeedUsers();
            SeedProducts();
            SeedTypeOfService();
            SeedClient();
            SeedSatelliteTV();
            SeedInternetService();
            SeedIPTV();           
        }
      
        private void SeedSatelliteTV()
        {
            SatelliteTV = new SatelliteTV()
            {
                Id=1,
                SerialNumber= 5000001,
                Name= "PomSat",
                ActiveUntilDate= DateTime.Now.AddMonths(1),
                ProductId= 5,
                IsActive=true
            };
        }
        private void SeedIPTV()
        {
            IPTV = new IPTV()
            {
                Id = 1,
                SerialNumber = 3000001,
                Name = "WinMat",
                ActiveUntilDate = DateTime.Now.AddMonths(1),
                ProductId = 13,
                IsActive=true
            };
        }
        private void SeedInternetService()
        {
            InternetService = new InternetService()
            {
                Id = 1,
                RouterMACAdress = "0C:8B:3A:25:0D:F4",
                Name = "InternetProduct75Mbps",
                ActiveUntilDate = DateTime.Now.AddMonths(1),
                ProductId = 3,
                IsActive=true
            };
        }
        private void SeedUsers()
        {
            var hasher = new PasswordHasher<IdentityUser>();
            {
                ClientUser = new IdentityUser()
                {
                    Id = "dea12896-c198-4129-b3f3-b893d8395082",
                    UserName = "client@mail.com",
                    NormalizedUserName = "client@mail.com",
                    Email = "client@mail.com",
                    NormalizedEmail = "client@mail.com"
                };
                ClientUser.PasswordHash = hasher.HashPassword(ClientUser, "clent123");

                CashierUser = new IdentityUser()
                {
                    Id = "6d5800ce-d826-4fc8-83d9-d6b3ac1f591e",
                    UserName = "cashier@mail.com",
                    NormalizedUserName = "cashier@mail.com",
                    Email = "cashier@mail.com",
                    NormalizedEmail = "cashier@mail.com"
                };
                CashierUser.PasswordHash = hasher.HashPassword(CashierUser, "cashier123");

                SupportUser = new IdentityUser()
                {
                    Id = "6d5610ce-d726-4fc8-83d9-d6b3ac1f591e",
                    UserName = "support@mail.com",
                    NormalizedUserName = "support@mail.com",
                    Email = "support@mail.com",
                    NormalizedEmail = "support@mail.com"
                };
                SupportUser.PasswordHash = hasher.HashPassword(SupportUser, "support123");
            }
        }
        private void SeedTypeOfService()
        {
            InternetType = new TypeOfService()
            {
                Id = 1,
                Name = "Internet"
            };
            SatTvType = new TypeOfService()
            {
                Id = 2,
                Name = "SatelliteTv"
            };
            IPTVType = new TypeOfService()
            {
                Id = 3,
                Name = "IPTV"
            };
        }
        private void SeedProducts()
        {
            InternetProduct25Mbps = new Product()
            {
                Id = 1,
                Name = "InternetProduct25Mbps",
                TypeId=1,
                Price = 10.99m
            }; 
            InternetProduct50Mbps = new Product()
            {
                Id = 2,
                Name = "InternetProduct50Mbps",
                TypeId=1,
                Price = 12.99m
            };
            InternetProduct75Mbps = new Product()
            {
                Id = 3,
                Name = "InternetProduct75Mbps",
                TypeId=1,
                Price = 14.99m
            }; 
            InternetProduct100Mbps = new Product()
            {
                Id = 4,
                Name = "InternetProduct100Mbps",
                TypeId=1,
                Price = 16.99m
            };
            TvBaseSat = new Product()
            {
                Id=5,
                Name = "Start",
                TypeId = 2,
                Price = 9.99m
            };
            TvFilmsSat = new Product()
            {
                Id = 6,
                Name = "Films",
                TypeId = 2,
                Price = 5.99m
            };
            TvSportSat = new Product()
            {
                Id = 7,
                Name = "Sport",
                TypeId = 2,
                Price = 11.99m
            };
            TvPopularscieneSat = new Product()
            {
                Id = 8,
                Name = "Popularsciene",
                TypeId = 2,
                Price = 8.99m
            };
            TvKidsSat = new Product()
            {
                Id = 9,
                Name = "Kids",
                TypeId = 2,
                Price = 3.99m
            };
            TvEroticSat = new Product()
            {
                Id = 10,
                Name = "Erotic",
                TypeId = 2,
                Price = 7.99m
            };
            TvBaseIPTV = new Product()
            {
                Id = 11,
                Name = "Start",
                TypeId = 3,
                Price = 9.99m
            };
            TvFilmsIPTV = new Product()
            {
                Id = 12,
                Name = "Films",
                TypeId = 3,
                Price = 5.99m
            };
            TvSportIPTV = new Product()
            {
                Id = 13,
                Name = "Sport",
                TypeId = 3,
                Price = 11.99m
            };
            TvPopularscieneIPTV = new Product()
            {
                Id = 14,
                Name = "Popularsciene",
                TypeId = 3,
                Price = 8.99m
            };
            TvKidsIPTV = new Product()
            {
                Id = 15,
                Name = "Kids",
                TypeId = 3,
                Price = 3.99m
            };
            TvEroticIPTV = new Product()
            {
                Id = 16,
                Name = "Erotic",
                TypeId = 3,
                Price = 7.99m
            };
        }

        private void SeedClient()
        {
            Client = new Client()
            {
                Id = 9999,
                FirstName = "Ангел",
                MiddleName = "Ангелов",
                LastName = "Ангелов",
                CivilNumber = "8801018899",
                Email = "angel.angelov@gmail.com",
                City = "Варна",
                StreetName = "Васил Левски",
                StreetNumber = "10А",
                InternetServiceId = 1,
                SatelliteTvId = 1,
                IPTVId = 1,
                PhoneNumber = "0888001100"
            };
        }
    }
}


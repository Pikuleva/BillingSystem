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
        public TypeOfService InternetType { get; set; }
        public TypeOfService SatTvType { get; set; }
        public TypeOfService IPTVType { get; set; }

        public SeedData()
        {
            SeedUsers();
            SeedProducts();
            SeedTypeOfService();
           
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
            TvBase = new Product()
            {
                Id=5,
                Name = "Start",
                TypeId = 2,
                Price = 9.99m
            };
            TvFilms = new Product()
            {
                Id = 6,
                Name = "Films",
                TypeId = 2,
                Price = 5.99m
            };
            TvSport = new Product()
            {
                Id = 7,
                Name = "Sport",
                TypeId = 2,
                Price = 11.99m
            };
            TvPopularsciene = new Product()
            {
                Id = 8,
                Name = "Popularsciene",
                TypeId = 2,
                Price = 8.99m
            };
            TvKids = new Product()
            {
                Id = 9,
                Name = "Kids",
                TypeId = 2,
                Price = 3.99m
            };
            TvErotic = new Product()
            {
                Id = 10,
                Name = "Erotic",
                TypeId = 2,
                Price = 7.99m
            };
            TvBase = new Product()
            {
                Id = 11,
                Name = "Start",
                TypeId = 3,
                Price = 9.99m
            };
            TvFilms = new Product()
            {
                Id = 12,
                Name = "Films",
                TypeId = 3,
                Price = 5.99m
            };
            TvSport = new Product()
            {
                Id = 13,
                Name = "Sport",
                TypeId = 3,
                Price = 11.99m
            };
            TvPopularsciene = new Product()
            {
                Id = 14,
                Name = "Popularsciene",
                TypeId = 3,
                Price = 8.99m
            };
            TvKids = new Product()
            {
                Id = 15,
                Name = "Kids",
                TypeId = 3,
                Price = 3.99m
            };
            TvErotic = new Product()
            {
                Id = 16,
                Name = "Erotic",
                TypeId = 3,
                Price = 7.99m
            };
        }
    }
}


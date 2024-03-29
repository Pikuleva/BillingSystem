﻿using BillingSystem.Infrastructure.DataModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BillingSystem.Infrastructure.Data.SeedDb
{
    public class ProductCofiguration: IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            var data = new SeedData();

            builder.HasData(new Product[] 
            {
                data.InternetProduct50Mbps,
                data.InternetProduct25Mbps,
                data.InternetProduct75Mbps,
                data.InternetProduct100Mbps,
                data.TvBaseSat,
                data.TvSportSat,
                data.TvKidsSat,
                data.TvEroticSat,
                data.TvFilmsSat,
                data.TvPopularscieneSat,

                data.TvSportIPTV,
                data.TvBaseIPTV,
                data.TvEroticIPTV,
                data.TvKidsIPTV,
                data.TvPopularscieneIPTV,
                data.TvFilmsIPTV
            });
        }
    }
}

using BillingSystem.Infrastructure.DataModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BillingSystem.Infrastructure.Data.SeedDb
{
    public class SatelliteTVConfiguration : IEntityTypeConfiguration<SatelliteTV>
    {
        public void Configure(EntityTypeBuilder<SatelliteTV> builder)
        {
            var data = new SeedData();

            builder.HasData(new SatelliteTV[] {data.SatelliteTV});
        }
    }
}

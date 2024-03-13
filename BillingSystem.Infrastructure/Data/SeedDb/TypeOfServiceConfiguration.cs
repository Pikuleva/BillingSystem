using BillingSystem.Infrastructure.DataModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BillingSystem.Infrastructure.Data.SeedDb
{
    public class TypeOfServiceConfiguration : IEntityTypeConfiguration<TypeOfService>
    {
        public void Configure(EntityTypeBuilder<TypeOfService> builder)
        {
            var data = new SeedData();

            builder.HasData(new TypeOfService[] { data.InternetType, data.SatTvType, data.IPTVType });
        }
    }
}

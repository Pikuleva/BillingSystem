
using BillingSystem.Infrastructure.DataModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BillingSystem.Infrastructure.Data.SeedDb
{
    public class IPTVConfiguration : IEntityTypeConfiguration<IPTV>
    {
        public void Configure(EntityTypeBuilder<IPTV> builder)
        {
            var data = new SeedData();
            builder.HasData(new IPTV[] { data.IPTV });
        }
    }
}

using BillingSystem.Infrastructure.DataModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BillingSystem.Infrastructure.Data.SeedDb
{
    public class InternetServiceConfiguration : IEntityTypeConfiguration<InternetService>
    {
        public void Configure(EntityTypeBuilder<InternetService> builder)
        {
            var data = new SeedData();
            builder.HasData(new InternetService[] { data.InternetService });
        }
    }
}

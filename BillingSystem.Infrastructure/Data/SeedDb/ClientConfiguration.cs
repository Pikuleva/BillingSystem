using BillingSystem.Infrastructure.DataModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BillingSystem.Infrastructure.Data.SeedDb
{
    public class ClientConfiguration : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            var data = new SeedData();

            builder.HasData(new Client[] {data.Client});
        }
    }
}

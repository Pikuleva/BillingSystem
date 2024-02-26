using BillingSystem.Infrastructure.DataModels;
using BillingSystem.Infrastructure.DataModels.Constants;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BillingSystem.Data
{
    public class BillingSystemDbContext : IdentityDbContext
    {
        public BillingSystemDbContext(DbContextOptions<BillingSystemDbContext> options)
            : base(options)
        {
        }

        public DbSet<Client> ClientsContracts { get; set; }
        public DbSet<InternetService> InternetServices { get; set; }    
        public DbSet<IPTV> IPTVs { get; set; }
        public DbSet<SatelliteTV> SatelliteTVs { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<ClientService> ClientsServices { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {

            builder.Entity<ClientService>()
                .HasKey(e => new { e.ClientId, e.IPTVId, e.TicketId, e.InternetServiceId });

            base.OnModelCreating(builder);
        }
    }
}
using BillingSystem.Infrastructure.DataModels;
using BillingSystem.Infrastructure.DataModels.Constants;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

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
        public DbSet<IPTVProduct> IPTVProducts { get; set; }
        public DbSet<SatelliteTVProduct> SatelliteTVProducts { get; set; }
        public DbSet<InternetProduct> InternetProducts { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<InternetProduct>()
                .Property(e => e.Price)
                .HasPrecision(18,2);

            builder.Entity<IPTVProduct>()
              .Property(e => e.Price)
              .HasPrecision(18, 2);

            builder.Entity<SatelliteTVProduct>()
              .Property(e => e.Price)
              .HasPrecision(18, 2);

           
            builder.Entity<ClientService>()
              .HasOne(e => e.Client)
              .WithMany(e=>e.ClientServices)
              .HasForeignKey(e => e.ClientId)
              .OnDelete(DeleteBehavior.NoAction);

            

            builder.Entity<ClientService>()
                .HasKey(e => new { e.ClientId, e.IPTVId, e.TicketId, e.InternetServiceId });

            base.OnModelCreating(builder);
        }
    }
}
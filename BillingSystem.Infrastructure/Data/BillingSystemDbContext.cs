using BillingSystem.Infrastructure.Data.SeedDb;
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

        public DbSet<Client> Clients { get; set; }
        public DbSet<InternetService> InternetServices { get; set; }    
        public DbSet<IPTV> IPTVs { get; set; }
        public DbSet<SatelliteTV> SatelliteTVs { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Product> Products { get; set; }
       


        protected override void OnModelCreating(ModelBuilder builder)
        {
           
            builder.Entity<Product>()
              .Property(e => e.Price)
              .HasPrecision(18, 2);

            builder.Entity<Client>()
                .HasOne(c=>c.InternetService)
                .WithMany()
                .HasForeignKey(c=>c.InternetServiceId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Client>()
         .HasOne(c => c.IPTV)
         .WithMany()
         .HasForeignKey(c => c.IPTVId)
         .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Client>()
         .HasOne(c => c.SatelliteTV)
         .WithMany()
         .HasForeignKey(c => c.SatelliteTvId)
         .OnDelete(DeleteBehavior.Restrict); 

            builder.Entity<InternetService>()
         .HasOne(c => c.Product)
         .WithMany()
         .HasForeignKey(c => c.ProductId)
         .OnDelete(DeleteBehavior.Restrict);



            builder.ApplyConfiguration(new UserConfiguration());
            builder.ApplyConfiguration(new ProductCofiguration());
            builder.ApplyConfiguration(new TypeOfServiceConfiguration());

            base.OnModelCreating(builder);
        }
    }
}
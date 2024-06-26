﻿using BillingSystem.Infrastructure.Data.SeedDb;
using BillingSystem.Infrastructure.DataModels;
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
        public DbSet<Client> Clients { get; set; }
        public DbSet<InternetService> InternetServices { get; set; }    
        public DbSet<IPTV> IPTVs { get; set; }
        public DbSet<SatelliteTV> SatelliteTVs { get; set; }
        public DbSet<Product> Products { get; set; }
       
        protected override void OnModelCreating(ModelBuilder builder)
        {          
            builder.Entity<Product>()
              .Property(e => e.Price)
              .HasPrecision(18, 2);

            builder.ApplyConfiguration(new UserConfiguration());
            builder.ApplyConfiguration(new ProductCofiguration());
            builder.ApplyConfiguration(new TypeOfServiceConfiguration());
            builder.ApplyConfiguration(new ClientConfiguration());
            builder.ApplyConfiguration(new InternetServiceConfiguration());
            builder.ApplyConfiguration(new IPTVConfiguration());
            builder.ApplyConfiguration(new SatelliteTVConfiguration());

            base.OnModelCreating(builder);
        }
    }
}
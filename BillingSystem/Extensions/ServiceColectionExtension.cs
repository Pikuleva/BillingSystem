using BillingSystem.Core.Contracts;
using BillingSystem.Core.Services;
using BillingSystem.Data;
using BillingSystem.Infrastructure.Common;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Microsoft.Extensions.DependencyInjection


{ 
    public static class ServiceColectionExtension
    {
        public static IServiceCollection AddApplicatoionServices(this IServiceCollection services)
        {
            services.AddScoped<IClientService, ClientService>();

            return services;
        }
        public static IServiceCollection AddApplicatoionDbContext(this IServiceCollection services, IConfiguration config)
        {
            var connectionString = config.GetConnectionString("DefaultConnection");
            services.AddDbContext<BillingSystemDbContext>(options =>
                options.UseSqlServer(connectionString));

            services.AddScoped<IRepository, Repository>();

            services.AddDatabaseDeveloperPageExceptionFilter();

            return services;
        }
        public static IServiceCollection AddApplicatoionIdentity(this IServiceCollection services, IConfiguration config)
        {
            services
               .AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
               .AddEntityFrameworkStores<BillingSystemDbContext>();

            return services;
        }
    }
}

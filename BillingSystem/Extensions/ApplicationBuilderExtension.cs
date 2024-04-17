using BillingSystem.Infrastructure.Data.SeedDb;
using Microsoft.AspNetCore.Identity;
using static BillingSystem.Core.Constants.RoleConstants;

namespace Microsoft.AspNetCore.Builder
{
    public static class ApplicationBuilderExtension
    {
        public static async Task CreateAdminRole(this IApplicationBuilder app)
        {
            using  var scope = app.ApplicationServices.CreateScope();
            var userManager = scope.ServiceProvider.GetRequiredService<UserManager<IdentityUser>>();
            var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();

            if (userManager !=null && roleManager != null && await roleManager.RoleExistsAsync(AdminRole) == false)
            {
                var role = new IdentityRole(AdminRole);
                await roleManager.CreateAsync(role);

                var admin = await userManager.FindByEmailAsync("admin@mail.com");

                if (admin != null)
                {
                    await userManager.AddToRoleAsync(admin, role.Name);
                }
            }
            if (userManager != null && roleManager != null && await roleManager.RoleExistsAsync(SupportRole) == false)
            {
                var role = new IdentityRole(SupportRole);
                await roleManager.CreateAsync(role);

                var support = await userManager.FindByEmailAsync("support@mail.com");

                if (support != null)
                {
                    await userManager.AddToRoleAsync(support, role.Name);
                }
            }
            if (userManager != null && roleManager != null && await roleManager.RoleExistsAsync(CashierRole) == false)
            {
                var role = new IdentityRole(CashierRole);
                await roleManager.CreateAsync(role);

                var cashier = await userManager.FindByEmailAsync("cashier@mail.com");

                if (cashier != null)
                {
                    await userManager.AddToRoleAsync(cashier, role.Name);
                }
            }
            if (userManager != null && roleManager != null && await roleManager.RoleExistsAsync(ClientRole) == false)
            {
                var role = new IdentityRole(ClientRole);
                await roleManager.CreateAsync(role);

                var client = await userManager.FindByEmailAsync("client@mail.com");

                if (client != null)
                {
                    await userManager.AddToRoleAsync(client, role.Name);
                }
            }
        }

    }
}

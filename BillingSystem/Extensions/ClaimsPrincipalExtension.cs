using Microsoft.AspNetCore.Server.IIS.Core;
using static BillingSystem.Core.Constants.RoleConstants;


namespace System.Security.Claims
{
    public static class ClaimsPrincipalExtension
    {
        public static string Id(this ClaimsPrincipal user)
        {
            return user.FindFirstValue(ClaimTypes.NameIdentifier);
        }
        public static bool IsAdmin(this ClaimsPrincipal user)
        {
            return user.IsInRole(AdminRole);
        }
        public static bool IsCashier(this ClaimsPrincipal user)
        {
            return user.IsInRole(CashierRole);
        }
        public static bool IsClient(this ClaimsPrincipal user)
        {
            return user.IsInRole(ClientRole);
        }
        public static bool IsSupport(this ClaimsPrincipal user)
        {
            return user.IsInRole(SupportRole);
        }
    }
}

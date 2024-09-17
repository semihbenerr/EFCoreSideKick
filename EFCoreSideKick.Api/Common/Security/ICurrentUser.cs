using System.Security.Claims;

namespace EFCoreSideKick.Api
{
    public interface ICurrentUser
    {
        bool IsAuthenticated { get; }
        ClaimsPrincipal User { get; }

        string GetUserId();
        string GetTenantId();
        string? GetClaim(string type);
        bool HasClaim(string type, string? value);
        bool IsInRole(string role);
    }
}
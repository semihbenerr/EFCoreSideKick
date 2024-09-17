using EFCoreSideKick.Api;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class SecurityExtensions
    {
        public static IServiceCollection AddCurrentUser(this IServiceCollection services)
        {
            services.AddHttpContextAccessor();
            services.AddSingleton<ICurrentUser, DefaultCurrentUser>();

            return services;
        }
    }
}

using EFCoreSideKick.Api;
using Microsoft.Extensions.DependencyInjection;

namespace EFCoreSideKick.Api
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddProjectServices(this IServiceCollection services)
        {
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<IEmployeeService, EmployeeService>();
            return services;
        }
    }
}

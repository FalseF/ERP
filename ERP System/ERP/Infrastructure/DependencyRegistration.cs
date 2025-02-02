using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace ERP.Infrastructure
{
    public static class DependencyRegistration
    {
        public static IServiceCollection RegisterApplicationServices(this IServiceCollection services)
        {
            services.AddScoped(typeof(IRepository<>), typeof(EfRepository<>));

            return services;
        }
    }
}

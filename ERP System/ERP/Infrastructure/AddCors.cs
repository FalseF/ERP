namespace ERP.Infrastructure
{
    public static class AddCors
    {
        public static IServiceCollection RegisterCors(this IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy("AllowAnyOrigin",
                    builder =>
                    {
                        builder.AllowAnyOrigin(); // Allow any origin
                        builder.AllowAnyMethod(); // Allow any HTTP method
                        builder.AllowAnyHeader(); // Allow any HTTP headers
                    });
            });
            return services;
        }
    }
}

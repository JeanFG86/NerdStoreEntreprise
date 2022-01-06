using NSE.WebAPI.Core.Identidade;

namespace NSE.Identidade.API.Config
{
    public static class ApiConfig
    {
        public static IServiceCollection AddApiConfiguration(this IServiceCollection services)
        {
            services.AddControllers();

            return services;
        }

        public static WebApplication UseApiConfiguration(this WebApplication app)
        {
            app.UseHttpsRedirection();

            app.UseAuthConfiguration();

            app.MapControllers();

            return app;
        }
    }
}

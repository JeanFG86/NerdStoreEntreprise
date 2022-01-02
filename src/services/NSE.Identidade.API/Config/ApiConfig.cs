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

            app.UseIdentityConfiguration();

            app.MapControllers();

            return app;
        }
    }
}

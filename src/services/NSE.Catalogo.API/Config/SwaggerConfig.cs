using Microsoft.OpenApi.Models;

namespace NSE.Catalogo.API.Config
{
    public static class SwaggerConfig
    {
        public static void AddSwaggerConfiguration(this IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "NerdStore Enterprise Identity API",
                    Description = "Descricao da parada",
                    Contact = new OpenApiContact() { Name = "Jean FG", Email = "jeanfg86@gmail.com" },
                    License = new OpenApiLicense() { Name = "MIT", Url = new Uri("https://opensource.org.licenses/MIT") }
                });
            });
        }

        public static void UseSwaggerConfiguration(this IApplicationBuilder app)
        {
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
            });

        }
    }
}

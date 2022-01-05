using Microsoft.EntityFrameworkCore;
using NSE.Catalogo.API.Data;

namespace NSE.Catalogo.API.Config
{
    public static class ApiConfig
    {
        public static void AddApiConfiguration(this IServiceCollection services, WebApplicationBuilder builder)
        {
            var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

            builder.Services.AddDbContext<CatalogoContext>(options =>
                options.UseNpgsql(connectionString));

            services.AddControllers();

            services.AddCors(options =>
            {
                options.AddPolicy("Total", builder =>
                    builder.AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader());
            });
        }

        public static void UseApiConfiguration(this WebApplication app)
        {
            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.UseCors("Total");

            app.MapControllers();
        }
    }
}

using Microsoft.EntityFrameworkCore;
using NSE.Carrinho.API.Data;
using NSE.WebAPI.Core.Identidade;

namespace NSE.Carrinho.API.Config
{
    public static class ApiConfig
    {
        public static void AddApiConfiguration(this IServiceCollection services, WebApplicationBuilder builder)
        {
            var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

            builder.Services.AddDbContext<CarrinhoContext>(options =>
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

            app.UseCors("Total");

            app.UseAuthConfiguration();

            app.MapControllers();
        }
    }
}

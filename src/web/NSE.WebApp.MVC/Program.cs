using NSE.WebApp.MVC.Config;
using NSE.WebApp.MVC.Controllers;
using NSE.WebApp.MVC.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddIdentityConfiguration();


var appSettingsSection = builder.Configuration.GetSection("AppSettings");
builder.Services.Configure<AppSettings>(appSettingsSection);

var appSettings = appSettingsSection.Get<AppSettings>();

builder.Services.AddMvcConfiguration();

builder.Services.RegisterServices(appSettings);

var app = builder.Build();


app.UseMvcConfiguration();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute("default", "{controller=Catalogo}/{action=Index}/{id?}");
});


app.Run();

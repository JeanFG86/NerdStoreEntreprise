using NSE.WebApp.MVC.Config;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddIdentityConfiguration();

builder.Services.AddMvcConfiguration();

var app = builder.Build();


app.UseMvcConfiguration();


app.Run();

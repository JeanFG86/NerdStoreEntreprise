using NSE.WebApp.MVC.Config;
using NSE.WebApp.MVC.Controllers;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddIdentityConfiguration();

builder.Services.AddMvcConfiguration();

builder.Services.RegisterServices();

var app = builder.Build();


app.UseMvcConfiguration();


app.Run();

using NSE.Identidade.API.Config;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddIdentityConfiguration(builder);

builder.Services.AddApiConfiguration();

builder.Services.AddSwaggerConfiguration();


var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseSwaggerConfiguration();

app.UseApiConfiguration();


app.Run();

using MediatR;
using NSE.Clientes.API.Config;
using NSE.WebAPI.Core.Identidade;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddApiConfiguration(builder);

builder.Services.AddJwtConfiguration(builder);

builder.Services.AddSwaggerConfiguration();

builder.Services.AddMediatR(typeof(Program));
builder.Services.RegisterServices();

var app = builder.Build();

app.UseSwaggerConfiguration();
app.UseApiConfiguration();

app.Run();


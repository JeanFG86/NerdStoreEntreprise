using Microsoft.EntityFrameworkCore;
using NSE.Catalogo.API.Config;
using NSE.Catalogo.API.Data;
using NSE.Catalogo.API.Data.Repository;
using NSE.Catalogo.API.Models;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddApiConfiguration(builder);

builder.Services.AddSwaggerConfiguration();

builder.Services.RegisterServices();

var app = builder.Build();

app.UseSwaggerConfiguration();
app.UseApiConfiguration();

app.Run();

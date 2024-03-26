using Microsoft.EntityFrameworkCore;
using Colegio.Core.Interfaces;
using Colegio.Infra;
using Colegio.Infra.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Configuración de la cadena de conexión desde appsettings.json
builder.Configuration.AddJsonFile("appsettings.json");
var configuration = builder.Configuration;

// Register DbContext and services
builder.Services.AddDbContext<ColegioContext>(options =>
{
    options.UseSqlServer(configuration.GetConnectionString("cadena"));
});

builder.Services.AddScoped<IUsuarioRepository, UsuarioRepository>();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
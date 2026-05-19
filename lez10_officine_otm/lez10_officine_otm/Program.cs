using lez10_officine_otm.Context;
using lez10_officine_otm.Repositories;
using lez10_officine_otm.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
#if DEBUG
builder.Services.AddDbContext<OfficinaContext>(options => options.UseSqlServer(
    builder.Configuration.GetConnectionString("DatabaseSviluppo")));
#else
builder.Services.AddDbContext<OfficinaContext>(options => options.UseSqlServer(
    builder.Configuration.GetConnectionString("DatabaseProduzione")));
#endif

builder.Services.AddScoped<ClienteRepository>();
builder.Services.AddScoped<ClienteService>();


builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

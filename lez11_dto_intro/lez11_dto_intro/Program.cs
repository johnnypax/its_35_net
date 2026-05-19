using lez11_dto_intro.Context;
using lez11_dto_intro.Repositories;
using lez11_dto_intro.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<OfficinaContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DatabaseSviluppo")));

builder.Services.AddScoped<ClienteService>();
builder.Services.AddScoped<ClienteRepository>();

builder.Services.AddScoped<InterventoService>();
builder.Services.AddScoped<InterventiRepository>();

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

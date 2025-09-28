using ACBaseAPI.Extensions;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SistemaBibliotecaAPI.Context;
using SistemaBibliotecaAPI.Models;

var builder = WebApplication.CreateBuilder(args);

if (builder.Environment.IsEnvironment("Testing"))
{
    builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
}
else
{
    builder.Services.AddDbContext<AppDbContext>(options =>
    {
        options.UseInMemoryDatabase("InMemoryDbForTesting");
    });
}

builder.Services.AddIdentity<Usuario, IdentityRole<long>>()
    .AddEntityFrameworkStores<AppDbContext>()
    .AddDefaultTokenProviders();

builder.Services.AddACBaseApiServices<AppDbContext>(builder.Configuration);

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
else
{
    app.UseExceptionHandler(options => { });
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseCors(option => option
    .AllowAnyOrigin()
    .AllowAnyMethod()
    .AllowAnyHeader());

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();

public partial class Program { }
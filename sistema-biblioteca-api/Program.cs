using ACBaseAPI;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SistemaBibliotecaAPI.Context;

var startup = new ACStartup<AppDbContext>();

startup.builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(startup.builder.Configuration.GetConnectionString("DefaultConnection")));

startup.builder.Services.AddIdentity<IdentityUser<int>, IdentityRole<int>>()
    .AddEntityFrameworkStores<AppDbContext>()
    .AddDefaultTokenProviders();

startup.Build();

startup.app.UseAuthentication();

startup.app.UseCors(option => option
    .AllowAnyOrigin()
    .AllowAnyMethod()
    .AllowAnyHeader());

startup.app.UseAuthorization();

startup.Run();

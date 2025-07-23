using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SalesWeb.Data;
using SalesWeb.Models;
using SalesWeb.Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<SalesWebContext>(options =>
    options.UseMySql(builder
    .Configuration
    .GetConnectionString("SalesWebContext"),
    ServerVersion.AutoDetect(builder
    .Configuration
    .GetConnectionString("SalesWebContext"))));

// Add services to the container.
builder.Services.AddControllersWithViews();

// Adicione o SellerService
builder.Services.AddScoped<SellerService>();

// Restante da configuração
builder.Services.AddControllersWithViews();

builder.Services.AddScoped<SeedingService>();


var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    var seedingService = services.GetRequiredService<SeedingService>();

    if (app.Environment.IsDevelopment())
    {
        seedingService.Seed();
    }
}


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();

}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"
);

app.Run();

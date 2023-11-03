using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PageCreator.Data;
using PageCreator.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<PageCreatorContext>(options =>

    options.UseSqlServer(builder.Configuration.GetConnectionString("PageCreatorContext") ?? throw new InvalidOperationException("Connection string 'PageCreatorContext' not found.")));
builder.Services.AddControllersWithViews();


var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;

    SeedData.Initialize(services);
}

app.UseStaticFiles();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}");

app.Run();

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using WebAppPhaseEndProject_01.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<PhaseEndProject_01DbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("PhaseEndProject_01DbContext") ?? throw new InvalidOperationException("Connection string 'PhaseEndProject_01DbContext' not found.")));

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

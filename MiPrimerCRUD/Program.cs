using Microsoft.EntityFrameworkCore;
using MiPrimerCRUD.Models;
using MiPrimerCRUD.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<MiContexto>(options=> 
options.UseSqlServer(builder.Configuration.GetConnectionString("MiConexion")));

builder.Services.AddSingleton<IGeneralService, GeneralService>();

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

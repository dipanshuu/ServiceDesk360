using WebApplicationProject27July.Context;
using WebApplicationProject27July.Repository;
using Microsoft.EntityFrameworkCore;
using System.Configuration;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IClientRepositorycs, SqlClientRepository>();
builder.Services.AddScoped<ClientDbContext, ClientDbContext>();
builder.Services.AddDbContext<ClientDbContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

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
    pattern: "{controller=Client}/{action=Index}/{id?}");

app.Run();

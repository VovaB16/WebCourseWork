using Microsoft.EntityFrameworkCore;
using OLX_MVC.Data;
using System.Reflection;
using Microsoft.AspNetCore.Identity;
using OLX_MVC.Data.Entities;
using OLX_MVC.Extentions;
using Microsoft.AspNetCore.Cors.Infrastructure;
using OLX_MVC.Services;

var builder = WebApplication.CreateBuilder(args);

string connStr = builder.Configuration.GetConnectionString("LocalDb")!;

// Add services to the container.
builder.Services.AddControllersWithViews();
// add custom services

// configure db context
builder.Services.AddDbContext<ShopDbContext>(opt => opt.UseSqlServer(connStr));

builder.Services.AddIdentity<User, IdentityRole>(
    options =>
        options.SignIn.RequireConfirmedAccount = false
    )
    .AddEntityFrameworkStores<ShopDbContext>()
    .AddDefaultTokenProviders()
    .AddDefaultUI();

builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());

builder.Services.AddDistributedMemoryCache();

builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(10);
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
});

builder.Services.AddScoped<ICartService, CartService>();

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var serviceProvider = scope.ServiceProvider;

    SeedExtensions.SeedRoles(serviceProvider).Wait();
    SeedExtensions.SeedAdmin(serviceProvider).Wait();
}

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.UseSession();

app.MapRazorPages();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
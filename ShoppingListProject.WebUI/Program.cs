using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;
using ShoppingListProject.BusinessLayer;
using ShoppingListProject.BusinessLayer.Manager;
using ShoppingListProject.BusinessLayer.Service;
using ShoppingListProject.DataLayer.Abstract;
using ShoppingListProject.DataLayer.Concrete;
using ShoppingListProject.DataLayer.Context;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<AppDbContext>(/*opt => opt.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))*/);
//builder.Services.AddScoped<IProductRepository, ProductRepository>(); // Örnek bir ekleme, gerçek implementasyonunuzu kullanýn.
//builder.Services.AddScoped<IUserRepository, UserRepository>();

// Oturum açma ayarlarý:
builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(x =>
{
    x.LoginPath = "/Admin/Login";
    x.LogoutPath = "/Admin/Logout";
    x.AccessDeniedPath = "/AccessDenied";
    x.Cookie.Name = "Admin";
    x.Cookie.MaxAge = TimeSpan.FromDays(1); // Cookie süresi 1 gün belirledik
    x.Cookie.IsEssential = true;
});
// Yetkilendirme ayarlarý:
builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("AdminPolicy", policy => policy.RequireClaim("Role", "Admin"));
    options.AddPolicy("UserPolicy", policy => policy.RequireClaim("Role", "User"));
});

var app = builder.Build();

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
app.UseAuthentication();

app.MapControllerRoute(
            name: "admin",
            pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
          );

app.MapControllerRoute(

    name: "default",
    pattern: "{controller=Products}/{action=Index}/{id?}");


app.Run();

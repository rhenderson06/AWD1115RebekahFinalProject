using FurnitureStore.Models.DataAccess;
using FurnitureStore.Models.DataAccess.Repositories;
using FurnitureStore.Models.DomainModels;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<FurnitureContext>(options =>
            options.UseSqlServer(builder.Configuration.GetConnectionString("FurnitureContext")));

builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
builder.Services.AddScoped<IFurnitureRepository, FurnitureRepository>();
builder.Services.AddScoped<Cart>(c => Cart.GetCart(c));
builder.Services.AddScoped<IOrderRepository, OrderRepository>();

builder.Services.AddHttpContextAccessor();
builder.Services.AddSession();

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

app.UseSession();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

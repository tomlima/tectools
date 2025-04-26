using Tectools.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Tectools.Application.Services;
using Tectools.Application.Interfaces;
using Tectools.Infrastructure.Interfaces;
using Tectools.Infrastructure.Repositories;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Db Context 
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseMySQL(connectionString));

// Register Application services
builder.Services.AddScoped<IComponentService, ComponentService>();
builder.Services.AddScoped<ICategoryService, CategoryService>();

// Register Repositories
builder.Services.AddScoped<IComponentRepository, ComponentRepository>();
builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();

builder.Services.AddSession();

var app = builder.Build();

// Seed database after the app is built but before it starts accepting requests
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    var context = services.GetRequiredService<ApplicationDbContext>();

    // Call your seed method
    DbInitializer.Seed(context);
}

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseSession();
app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();


app.Run();
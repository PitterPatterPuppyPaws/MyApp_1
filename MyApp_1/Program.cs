using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

using MyApp_1.Data;

var builder = WebApplication.CreateBuilder(args);

if(builder.Environment.IsDevelopment()) {
    builder.Services.AddDbContext<MyApp_1DbContext>(options => options.UseSqlite(
            builder.Configuration.GetConnectionString("MyApp_1DbContext")
    ));
}

builder.Services.AddControllersWithViews();
builder.Services.AddHttpLogging(logging => {}); // Add http logging middleware with default settings

var app = builder.Build();

// Enable http logging for everything called after this line (ex: UseStaticFiles())
// Everything called before UseHttpLogging() will not have http logging
app.UseHttpLogging();

//app.MapGet("/", () => "Hello World!");

// app.MapControllerRoute(
//     name: "default",
//     pattern: "{controller=home}/{action=index}/{id?}"
// ).WithStaticAssets();
app.MapControllers().WithStaticAssets();


app.MapStaticAssets();

app.Run();

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

using MyApp_1.Data;

var builder = WebApplication.CreateBuilder(args);

if(builder.Environment.IsDevelopment()) {
    builder.Services.AddDbContext<MyApp_1DbContext>(options =>
        options.UseSqlite(
            builder.Configuration.GetConnectionString("MyApp_1DbContext")
        ));
}

builder.Services.AddControllersWithViews();

var app = builder.Build();

//app.MapGet("/", () => "Hello World!");
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=home}/{action=index}/{id?}"
).WithStaticAssets();

app.MapStaticAssets();

app.Run();

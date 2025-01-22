using Microsoft.AspNetCore.Identity;
using UniFood.Models.Context;
using Microsoft.EntityFrameworkCore;
using UniFood.Data.Interfaces;
using UniFood.Data.Services;
using UniFood.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddScoped<IFoodRepository, FoodRepository>();

builder.Services.AddDbContext<UfContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("Default"));
});



// Authentication
builder.Services.AddIdentity<Student, IdentityRole>(options =>
    {
        options.Password.RequireDigit = true; 
        options.Password.RequireLowercase = false;
        options.Password.RequireUppercase = false;
        options.Password.RequireNonAlphanumeric = false;
        options.Password.RequiredLength = 10;
    })
    .AddEntityFrameworkStores<UfContext>();

builder.Services.AddAuthentication();
builder.Services.AddAuthorization();
builder.Services.AddMemoryCache();
builder.Services.AddSession();  // Cookie authentication

builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("RequireAdminRole", policy => policy.RequireRole("Admin"));
});



// async Task SeedRoles(RoleManager<IdentityRole> roleManager)
// {
//     var roles = new[] { "Admin", "Student" };
//
//     foreach (var role in roles)
//     {
//         if (!await roleManager.RoleExistsAsync(role))
//         {
//             await roleManager.CreateAsync(new IdentityRole(role));
//         }
//     }
// }


var app = builder.Build();

// using (var scope = app.Services.CreateScope())
// {
//     var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();
//     await SeedRoles(roleManager);
// }

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}



// Unpin This part to create an admin account.
// using (var scope = app.Services.CreateScope())
// {
//     var services = scope.ServiceProvider; 
//     var userManager = services.GetRequiredService<UserManager<Student>>();
//     var roleManager = services.GetRequiredService<RoleManager<IdentityRole>>();
//     
//     if (!await roleManager.RoleExistsAsync("Admin"))
//     {
//         await roleManager.CreateAsync(new IdentityRole("Admin"));
//         await roleManager.CreateAsync(new IdentityRole("Student"));
//     }
//
//     var adminName = "Admin";
//     var adminEmail = "admin@gmail.com";
//     var adminPassword = "Admin1234";
//     // var adminUser = await userManager.FindByEmailAsync(adminEmail);
//     // if (adminUser == null)
//     // {
//     var adminUser = new Student
//     {
//         UserName = adminName, Email = adminEmail, EmailConfirmed = true
//     };
//     await userManager.CreateAsync(adminUser, adminPassword);
//     await userManager.AddToRoleAsync(adminUser, "Admin");
//     // }
// }




app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

// Admin Area
app.MapAreaControllerRoute(
    name: "Admin",
    areaName: "Admin",
    pattern: "Admin/{controller=Home}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
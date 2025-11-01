using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using PetAdoptionPortal.Infrastructure.Data;
using PetAdoptionPortal.Services.Interfaces;
using PetAdoptionPortal.Services.Implementations;
using PetAdoptionPortal.Web.Security; // we'll add a custom validator

var builder = WebApplication.CreateBuilder(args);

// Connection string (edit if necessary)
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Identity with custom password validator (to enforce 2 uppercase, 3 digits, 3 symbols)
builder.Services.AddDefaultIdentity<IdentityUser>(options =>
{
    // Basic toggles (we'll enforce counts with custom validator)
    options.Password.RequireDigit = false;
    options.Password.RequireUppercase = false;
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequiredLength = 8;
})
.AddEntityFrameworkStores<AppDbContext>();

// Register custom password validator
builder.Services.AddTransient<IPasswordValidator<IdentityUser>, CustomPasswordValidator>();

// Register services
builder.Services.AddScoped<IPetService, PetService>();

builder.Services.AddControllersWithViews();

var app = builder.Build();

// usual middleware...
if (!app.Environment.IsDevelopment()) { app.UseExceptionHandler("/Home/Error"); app.UseHsts(); }
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();
app.MapControllerRoute(name: "default", pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages(); // Identity UI

app.Run();

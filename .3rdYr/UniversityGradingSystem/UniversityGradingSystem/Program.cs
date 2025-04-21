using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using UniversityGradingSystem.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<TuitionInforContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("TuitionInforContext") ?? throw new InvalidOperationException("Connection string 'TuitionInforContext' not found.")));
builder.Services.AddDbContext<StudentInfoContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("StudentInfoContext") ?? throw new InvalidOperationException("Connection string 'StudentInfoContext' not found.")));
builder.Services.AddDbContext<GradesInfoContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("GradesInfoContext") ?? throw new InvalidOperationException("Connection string 'GradesInfoContext' not found.")));

// Add services to the container.
builder.Services.AddControllersWithViews();

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

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

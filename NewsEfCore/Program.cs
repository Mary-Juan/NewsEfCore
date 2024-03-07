using Microsoft.EntityFrameworkCore;
using NewsEfCore.DataAccess.Contexts;
using NewsEfCore.DataAccess.Repositories;
using NewsEfCore.DataAccess.Repositories.Interfaces;
using NewsEfCore.Services;
using NewsEfCore.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();


#region DbContext

builder.Services.AddDbContext<NewsContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("NewsDbConnectionString"));
});

#endregion

#region IOC

builder.Services.AddScoped<INewsRepository, NewsRepository>();
builder.Services.AddScoped<ICategoryRepository,CategoryRepository>();
builder.Services.AddScoped<IUserRpository, UserRpository>();
builder.Services.AddScoped<IUserService,UserService>();
builder.Services.AddScoped<INewsService, NewsService>();

#endregion


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

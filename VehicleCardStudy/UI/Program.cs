using VhCardDataAccess.Extensions;
using VhCardEntity.Concrete;
using Microsoft.EntityFrameworkCore;
using VhCardBusiness.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<VhCardCaseContext>(o =>
{
    o.UseSqlServer(builder.Configuration.GetConnectionString("MyConnection"));
});
builder.Services.AddBusinessDependencies();
builder.Services.AddControllersWithViews();
var app = builder.Build();


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Admin/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Admin}/{action=Index}/{id?}");

app.Run();

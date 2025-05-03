using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using WebLink.Data;
//var builder = WebApplication.CreateBuilder(args);

var builder = WebApplication.CreateBuilder(new WebApplicationOptions
{
    EnvironmentName = Environments.Production
    // 本当にサーバー上に公開するときには EnvironmentName = Environments.Production に変更する
    // そうしないとエラーの内容によっては他人にみられると困るものが見えてしまう
});

builder.Services.AddDbContext<WebLinkContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("WebLinkContext") ?? throw new InvalidOperationException("Connection string 'WebLinkContext' not found.")));

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

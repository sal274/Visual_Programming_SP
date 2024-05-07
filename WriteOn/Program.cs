using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using WriteOn.Data;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddHttpClient();
builder.Services.AddSqlite<WriteOnDbContext>("Data Source=WriteOnDatabase.db");

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

// Allows navigation
app.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");

app.Run();

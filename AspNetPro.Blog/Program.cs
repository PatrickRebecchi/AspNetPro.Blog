using AspNetPro.Blog.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();

builder.Services.AddDbContext<BlogContext> ((optionsAction) =>
{
    var connString = builder.Configuration.GetConnectionString("BlogConnection");
    optionsAction.UseSqlServer(connString);

});

var app = builder.Build();

app.UseStaticFiles();

app.MapRazorPages();

app.Run();

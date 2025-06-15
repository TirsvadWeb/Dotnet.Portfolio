using Microsoft.EntityFrameworkCore;
using Portfolio.Components;
using Portfolio.Core.Repository.IRepository;
using Portfolio.Data;
using Portfolio.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//if (builder.Environment.IsDevelopment())
//{
//    builder.Services.AddDbContext<PortfolioDbContext>(options =>
//        options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));
//}
//else
//{
//builder.Services.AddDbContext<PortfolioDbContext>(options =>
//    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddDbContext<PortfolioDbContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));
//}

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents()
    .AddInteractiveWebAssemblyComponents();

builder.Services.AddScoped<IGenreRepository, GenreRepository>();
builder.Services.AddScoped<IPortfolioItemRepository, PortfolioItemRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseAntiforgery();

app.MapStaticAssets();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode()
    .AddInteractiveWebAssemblyRenderMode()
    .AddAdditionalAssemblies(typeof(Portfolio.Client._Imports).Assembly);

app.Run();

using Microsoft.EntityFrameworkCore;
using Portfolio.Data.Data;
using Portfolio.Data.Services;
using Portfolio.Web.Components;
using Portfolio.Web.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
	.AddInteractiveServerComponents();

builder.Services.AddDbContext<PortfolioDbContext>(options =>
	options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))
);


// user defined services
builder.Services.AddScoped<IResumeService, ResumeService>();
builder.Services.AddHttpClient<IGitHubService, GitHubService>(client => 
{
	client.BaseAddress = new Uri("https://api.github.com/");
	client.DefaultRequestHeaders.Add("Accept", "application/vnd.github+json");
	client.DefaultRequestHeaders.Add("User-Agent", "Portfolio");

	client.DefaultRequestHeaders.Add("X-GitHub-Api-Version", "2026-03-10");
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
	app.UseExceptionHandler("/Error", createScopeForErrors: true);
	// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
	app.UseHsts();
}
app.UseStatusCodePagesWithReExecute("/not-found", createScopeForStatusCodePages: true);
app.UseHttpsRedirection();

app.UseAntiforgery();

app.MapStaticAssets();
app.MapRazorComponents<App>()
	.AddInteractiveServerRenderMode();

app.Run();

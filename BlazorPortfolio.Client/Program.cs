using BlazorPortfolio.Client;
using BlazorPortfolio.Client.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddScoped<ProjectService>();
builder.Services.AddScoped<LinkService>();
builder.Services.AddScoped<PortfolioService>();


builder.Services.AddMudServices();

await builder.Build().RunAsync();

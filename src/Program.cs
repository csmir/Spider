using Spider;
using Spider.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddScoped<ArticleService>();
builder.Services.AddScoped<TimelineService>();

builder.Services.AddMudServices();

builder.Logging.SetMinimumLevel(LogLevel.Debug);

await builder.Build().RunAsync();

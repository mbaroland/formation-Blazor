using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using dataForm;
using Syncfusion.Blazor;
using Blazored.LocalStorage;
using Microsoft.Extensions.Options;
using Microsoft.EntityFrameworkCore;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
builder.Services.AddSyncfusionBlazor();
builder.Services.AddBlazoredLocalStorage();

//builder.Services.AddDbContext<DataContext>(options => options.UseNpgsql(Configuration.GetConnectionString("DataContext")));

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

await builder.Build().RunAsync();

using System.Globalization;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MyBlazor.Libraries.Product;
using MyBlazor.Libraries.ShoppingCart;
using MyBlazor.Libraries.Storage;
using MyBlazorApp;
using MyBlazorApp.Client;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

var httpClient = new HttpClient
{
    BaseAddress = new Uri(builder.HostEnvironment.BaseAddress)
};
builder.Services.AddScoped(h =>httpClient);

using var responseP = await httpClient.GetAsync("ProductSettings."
    +
    builder.HostEnvironment.Environment
    +".json");



if (responseP.IsSuccessStatusCode)

{
    using var streamP = await responseP.Content.ReadAsStreamAsync();
    builder.Configuration.AddJsonStream(streamP);
}

builder.Services.AddSingleton<IStorgeService, StorageService>();
builder.Services.AddTransient<IProductService, ProductService>();
builder.Services.AddTransient<IShoppingCartService, ShoppingCartService>();
//zaban pishfarz karbar <englisch>
//set backend & UI frontend
CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("fa-IR");
CultureInfo.DefaultThreadCurrentUICulture = new CultureInfo("fa-IR");

builder.Services.AddLocalization();

await builder.Build().RunAsync();

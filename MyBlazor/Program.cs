using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MyBlazor;
using MyBlazor.Libraries.Product;
using MyBlazor.Libraries.ShoppingCart;
using MyBlazor.Libraries.ShoppingCartService.Models;
using MyBlazor.Libraries.Storage;
using MyBlazorApp;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

var httpClient = new HttpClient
{
    BaseAddress = new Uri(builder.HostEnvironment.BaseAddress)
};
builder.Services.AddScoped(h =>httpClient);

using var response = await httpClient.GetAsync("ProductSettings.json");;

using var stream = await response.Content.ReadAsStreamAsync();

builder.Configuration.AddJsonStream(stream);



builder.Services.AddSingleton<IStorgeService, StorageService>();
builder.Services.AddTransient<IProductService, ProductService>();
builder.Services.AddTransient<IShoppingCartService, ShoppingCartService>();



await builder.Build().RunAsync();

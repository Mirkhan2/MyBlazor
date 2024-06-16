using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MyBlazor;
using MyBlazor.Libraries.Product;
using MyBlazor.Libraries.ShoppingCart;
using MyBlazor.Libraries.ShoppingCartService.Models;
using MyBlazor.Libraries.Storage;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddSingleton<IStorgeService, StorageService>();
builder.Services.AddTransient<IProductService, ProductService>();
builder.Services.AddTransient<IShoppingCartService, ShoppingCartService>();



await builder.Build().RunAsync();

global using BlazingPizza.Shared;
global using BlazingPizza.Client;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddScoped<HttpClient>(sp =>
    new HttpClient
    {
        BaseAddress = new Uri(builder.HostEnvironment.BaseAddress)
    });

builder.Services.AddScoped<IRepository, HttpRepository>();
builder.Services.AddScoped<OrderState>();

await builder.Build().RunAsync();

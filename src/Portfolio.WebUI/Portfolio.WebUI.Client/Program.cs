using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

//builder.Services
//    .AddHttpClient("API", c => c.BaseAddress = new Uri("https://localhost:5001/"))
//    .AddTypedClient<IPortfolioClient>(http => RestService.For<IPortfolioClient>(http));

await builder.Build().RunAsync();

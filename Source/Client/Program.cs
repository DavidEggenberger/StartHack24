using Blazored.Modal;
using Client;
using Client.BuildingBlocks.Auth;
using Client.BuildingBlocks.Http;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection.Extensions;
using System.Net.Http.Headers;

namespace Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);

            builder.Services.AddBlazoredModal();

            builder.Services.AddTransient<AuthorizedHandler>();
            builder.Services.TryAddSingleton<HostAuthenticationStateProvider>();
            builder.Services.TryAddSingleton<AuthenticationStateProvider, HostAuthenticationStateProvider>();

            builder.Services.AddHttpClient(HttpClientConstants.DefaultHttpClient, client =>
            {
                client.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            });

            builder.Services.AddHttpClient(HttpClientConstants.AuthenticatedHttpClient, client =>
            {
                client.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            }).AddHttpMessageHandler<AuthorizedHandler>();

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            builder.Services.AddScoped<HttpClientService>();
            builder.Services.AddScoped<AuthorizedHttpClientService>();

            builder.Services.AddAuthorizationCore();

            await builder.Build().RunAsync();
        }
    }
}

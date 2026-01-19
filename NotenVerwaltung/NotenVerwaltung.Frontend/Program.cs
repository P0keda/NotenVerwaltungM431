using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using NotenVerwaltung.Frontend.Services;

namespace NotenVerwaltung.Frontend
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");
            builder.RootComponents.Add<HeadOutlet>("head::after");

            builder.Services.AddScoped(sp => new HttpClient
            {
                BaseAddress = new Uri(builder.HostEnvironment.BaseAddress)
            });

            builder.Services.AddScoped<AuthService>();
            builder.Services.AddScoped<LocalStorageService>();
            builder.Services.AddScoped<RequestService>();
            builder.Services.AddScoped<MarkService>();
            builder.Services.AddScoped<ITeacherService, TeacherService>();

            var host = builder.Build();

            var auth = host.Services.GetRequiredService<AuthService>();
            await auth.InitializeAsync();

            var req = host.Services.GetRequiredService<RequestService>();
            await req.InitializeAsync();

            await host.RunAsync();
        }
    }
}
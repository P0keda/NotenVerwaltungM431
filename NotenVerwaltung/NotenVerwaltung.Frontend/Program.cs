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
                BaseAddress = new Uri("https://localhost:7086/api/")
            });

            builder.Services.AddScoped<IAuthService, AuthService>();
            builder.Services.AddScoped<IMarkService, MarkService>();
            builder.Services.AddScoped<IMarkAdjustmentService, MarkAdjustmentService>();
            builder.Services.AddScoped<ITeacherService, TeacherService>();
            builder.Services.AddScoped<IProrectorService, ProrectorService>();
            builder.Services.AddScoped<IStudentService, StudentService>();
            builder.Services.AddScoped<ISubjectService, SubjectService>();

            var host = builder.Build();

            await host.RunAsync();
        }
    }
}
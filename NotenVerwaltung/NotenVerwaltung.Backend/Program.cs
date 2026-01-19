
using Microsoft.EntityFrameworkCore;
using NotenVerwaltung.Backend.Repositories;
using NotenVerwaltung.Backend.Services;

namespace NotenVerwaltung.Backend
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

            builder.Services.AddDbContext<AppDbContext>(options =>
            {
                options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
            });

            builder.Services.AddScoped<ITeacherRepository, TeacherRepository>();
            builder.Services.AddScoped<ITeacherService, TeacherService>();
            builder.Services.AddScoped<ISubjectService, SubjectService>();
            builder.Services.AddScoped<ISubjectRepository, SubjectRepository>();
            builder.Services.AddScoped<IStudentRepository, StudentRepository>();
            builder.Services.AddScoped<IStudentService, StudentService>();
            builder.Services.AddScoped<IProrectorRepository, ProrectorRepository>();
            builder.Services.AddScoped<IProrectorService, ProrectorService>();
            builder.Services.AddScoped<IGradeRepository, GradeRepository>();
            builder.Services.AddScoped<IGradeService, GradeService>();
            builder.Services.AddScoped<IChangeRequestRepository, ChangeRequestRepository>();
            builder.Services.AddScoped<IChangeRequestService, ChangeRequestService>();
            builder.Services.AddScoped<IAuthService, AuthService>();
            var app = builder.Build();



            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}

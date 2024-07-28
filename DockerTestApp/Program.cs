using DockerTestApp.Abstractions;
using DockerTestApp.Database;
using DockerTestApp.Extensions;
using DockerTestApp.Repositories;

namespace DockerTestApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllers();
            builder.Services.AddScoped<PostgreSQLContext>();
            builder.Services.AddScoped<IUserRepository, UserRepository>();
            var app = builder.Build();
            app.ApplyMigrations();
            app.MapControllers();
           
            app.MapGet("/", () => "Hello World!");

            app.Run();
        }
    }
}

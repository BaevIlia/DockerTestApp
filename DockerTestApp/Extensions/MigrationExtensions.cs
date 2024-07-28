using DockerTestApp.Database;
using Microsoft.EntityFrameworkCore;

namespace DockerTestApp.Extensions
{
    public static class MigrationExtensions
    {
        public static void ApplyMigrations(this IApplicationBuilder app) 
        {
            using IServiceScope scope = app.ApplicationServices.CreateScope();

            using PostgreSQLContext dbContext = 
                scope.ServiceProvider.GetService<PostgreSQLContext>();

            dbContext.Database.Migrate();
        }
    }
}

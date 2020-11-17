using Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.DependencyInjection;
using System.Configuration;

namespace UI.IoC
{
    public static class DatabaseConfiguration
    {
        public static void ConfigureDatabase(this IServiceCollection services)
        {
            services.AddDbContext<ApplicationContext>(options =>
                options.UseSqlite("Data Source=FruitLuggage.db"));
        }

        public class ApplicationContextFactory : IDesignTimeDbContextFactory<ApplicationContext>
        {
            public ApplicationContext CreateDbContext(string[] args)
            {
                var optionsBuilder = new DbContextOptionsBuilder<ApplicationContext>();
                optionsBuilder.UseSqlite("Data Source=FruitLuggage.db");

                return new ApplicationContext(optionsBuilder.Options);
            }
        }
    }
}

using Microsoft.Extensions.DependencyInjection;

namespace UI.IoC
{
    public static class DependencyResolver
    {
        public static void Resolve(this IServiceCollection services)
        {
            services.ConfigureDatabase();
            services.ConfigureServices();
            services.ConfigureRepositories();
            services.ConfigureEncryptor();
            services.AddSingleton<Login>();
        }
    }
}

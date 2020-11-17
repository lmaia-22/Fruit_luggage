using Microsoft.Extensions.DependencyInjection;
using Services;

namespace UI.IoC
{
    public static class ServiceConfiguration
    {
        public static void ConfigureServices(this IServiceCollection services)
        {
            services.AddSingleton<ICredentialsService, CredentialsService>();
            services.AddSingleton<IUserService, UserService>();
        }
    }
}

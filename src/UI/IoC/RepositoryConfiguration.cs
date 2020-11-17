using Infrastructure.Repositories;
using Infrastructure.Repositories.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace UI.IoC
{
    public static class RepositoryConfiguration
    {
        public static void ConfigureRepositories(this IServiceCollection services)
        {
            services.AddSingleton<IBoxStorageRepository, BoxStorageRepository>();
            services.AddSingleton<IBoxTypeRepository, BoxTypeRepository>();
            services.AddSingleton<IClientRepository, ClientRepository>();
            services.AddSingleton<IDOCRepository, DOCRepository>();
            services.AddSingleton<IPrintRepository, PrintRepository>();
            services.AddSingleton<IProductBoxRepository, ProductBoxRepository>();
            services.AddSingleton<IProductRepository, ProductRepository>();
            services.AddSingleton<IReportRepository, ReportRepository>();
            services.AddSingleton<IUserRepository, UserRepository>();
        }
    }
}

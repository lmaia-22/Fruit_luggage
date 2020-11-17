using Microsoft.Extensions.DependencyInjection;
using Utils.Encryptor;

namespace UI.IoC
{
    public static class EncryptorConfiguration
    {
        public static void ConfigureEncryptor(this IServiceCollection services)
        {
            services.AddSingleton<IEncryptor, SHA256Encryptor>();
        }
    }
}

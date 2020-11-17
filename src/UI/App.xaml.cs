using Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using Services;
using System.Windows;
using UI.IoC;

namespace UI
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly ServiceProvider _serviceProvider;

        public App()
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.Resolve();
            _serviceProvider = serviceCollection.BuildServiceProvider();
        }

        private void OnStartup(object sender, StartupEventArgs e)
        {
            var login = _serviceProvider.GetService<Login>();
            login.Show();
        }
    }
}

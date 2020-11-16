using Infrastructure;
using Services;
using System.Windows;
using Unity;

namespace UI
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            var container = new UnityContainer();
            //make sure your container is configured
            container.RegisterType<IUserService, UserService>();
            container.RegisterType<ApplicationContext>();
        }
    }
}

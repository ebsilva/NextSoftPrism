using Prism.Ioc;
using NextSoftPrism.Views;
using System.Windows;
using Prism.Modularity;
using NextSoftPrism.Modules.MainModule;
using NextSoftPrism.Services.Interfaces;
using NextSoftPrism.Services;

namespace NextSoftPrism
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        protected override Window CreateShell() => Container.Resolve<MainWindow>();

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<IMessageService, MessageService>();
        }

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog) => moduleCatalog.AddModule<MainModule>();
    }
}

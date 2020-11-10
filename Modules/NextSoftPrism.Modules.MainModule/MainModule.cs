using NextSoftPrism.Core;
using NextSoftPrism.Modules.MainModule.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace NextSoftPrism.Modules.MainModule
{
    public class MainModule : IModule
    {
        private readonly IRegionManager _regionManager;

        public MainModule(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }

        public void OnInitialized(IContainerProvider containerProvider)
        {
            _regionManager.RequestNavigate(RegionNames.ContentRegion, "MainView");
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<MainView>();
        }
    }
}
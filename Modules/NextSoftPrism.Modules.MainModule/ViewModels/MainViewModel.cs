using NextSoftPrism.Core.Mvvm;
using NextSoftPrism.Services.Interfaces;
using Prism.Regions;

namespace NextSoftPrism.Modules.MainModule.ViewModels
{
    public class MainViewModel : RegionViewModelBase
    {
        private string _message;
        public string Message
        {
            get { return _message; }
            set { SetProperty(ref _message, value); }
        }

        public MainViewModel(IRegionManager regionManager, IMessageService messageService) : base(regionManager)
        {
            Message = messageService.GetMessage();
        }

        public override void OnNavigatedTo(NavigationContext navigationContext)
        {
            //do something
        }
    }
}

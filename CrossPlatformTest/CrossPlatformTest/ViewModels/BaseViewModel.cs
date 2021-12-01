using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Threading.Tasks;

namespace CrossPlatformTest.ViewModels
{
    public class BaseViewModel : BindableBase, INavigationAware
    {
        public BaseViewModel(INavigationService navigationService)
        {
            NavigationService = navigationService;
        }
        public INavigationService NavigationService { get; }

        private bool isBusy;
        public bool IsBusy
        {
            get => isBusy;
            set => SetProperty(ref isBusy, value);
        }


        public virtual void OnNavigatedFrom(INavigationParameters parameters)
        {
        }

        public virtual void OnNavigatedTo(INavigationParameters parameters)
        {
        }

        protected async Task ExecuteBusyAction(Func<Task> theBusyAction)
        {
            if (IsBusy)
                return;
            try
            {
                IsBusy = true;
                await theBusyAction();
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}

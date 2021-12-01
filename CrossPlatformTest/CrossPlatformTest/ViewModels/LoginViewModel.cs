using CrossPlatformTest.Views;
using Prism.Navigation;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Shapes;

namespace CrossPlatformTest.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        public Command LoginCommand { get; }

        public string UserName { get; set; }
        public string Password { get; set; }

        private bool isError;
        public bool IsError
        {
            get => isError;
            set => SetProperty(ref isError, value);
        }


        public LoginViewModel(INavigationService navigationService) : base(navigationService)
        {
            LoginCommand = new Command<Ellipse>(OnLoginClicked);
        }

        private async void OnLoginClicked(Ellipse ellipse)
        {
            await ScaleEffect(ellipse);

            if (UserName == "fagner.santos@ciandt.com" && Password == "1234")
            {
                IsError = false;
                await NavigationService.NavigateAsync(nameof(MainPage));
            }
            else
            {
                IsError = true;
            }
        }

        private async Task ScaleEffect(Ellipse ellipse)
        {
            await ellipse.ScaleTo(1.25, 25, Easing.Linear);
            await Task.Delay(50);
            await ellipse.ScaleTo(1, 50, Easing.Linear);
        }
    }
}

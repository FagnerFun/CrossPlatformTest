using CrossPlatformTest.Services;
using CrossPlatformTest.ViewModels;
using CrossPlatformTest.Views;
using Prism.Ioc;
using Refit;

namespace CrossPlatformTest.Extension
{
    public static class ContainerRegistryExtension
    {
        public static void RegisterDependencyInjection(this IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<LoginPage, LoginViewModel>();
            containerRegistry.RegisterForNavigation<MainPage, MainViewModel>();


            containerRegistry.RegisterInstance(RestService.For<IProductClient>(AppSettings.ApiUrl));
        }
    }
}

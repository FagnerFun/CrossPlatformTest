using TechTalk.SpecFlow;
using Xamarin.UITest;

namespace CrossPlatformTest.UITest.Base
{
    [Binding]
    public class SetupSteps
    {
        [Given("a started app")]
        public void StartApp()
        {
            if (Global.Platform == Platform.iOS)
            {
                Global.App = ConfigureApp
                    .iOS
                    .InstalledApp("com.companyname.crossplatformtest")
                    .PreferIdeSettings()
                    .EnableLocalScreenshots()
                    .StartApp();
            }
            else
            {
                Global.App = ConfigureApp
                    .Android
                    .InstalledApp("com.companyname.crossplatformtest")
                    .PreferIdeSettings()
                    .EnableLocalScreenshots()
                    .StartApp();
            }
        }
    }
}

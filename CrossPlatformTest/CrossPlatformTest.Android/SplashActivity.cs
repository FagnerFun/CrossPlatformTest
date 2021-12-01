using Android.App;
using Android.Content;
using Android.OS;
using System.Threading.Tasks;

namespace CrossPlatformTest.Droid
{
    [Activity(Theme = "@style/MyTheme.Splash", MainLauncher = true, NoHistory = true)]
    public class SplashActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
        }

        protected override void OnResume()
        {
            base.OnResume();
            new Task(async () => {
                await Task.Delay(3000);
                StartActivity(new Intent(Application.Context, typeof(MainActivity)));
            }).Start();
        }
    }
}
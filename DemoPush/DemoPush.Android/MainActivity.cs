
using Android.App;
using Android.Content.PM;
using Android.OS;
using Com.OneSignal;

namespace DemoPush.Droid
{
    [Activity(Label = "DemoPush", Icon = "@drawable/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);

            OneSignal.Current.StartInit("6f02ec21-5c85-4674-9669-2c143a1dcff9").EndInit();

            global::Xamarin.Forms.Forms.Init(this, bundle);
            LoadApplication(new App());
        }
    }
}
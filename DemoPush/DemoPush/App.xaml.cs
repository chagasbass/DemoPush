using Com.OneSignal;

using Xamarin.Forms;

namespace DemoPush
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new DemoPush.MainPage();

            OneSignal.Current.StartInit("OnSignal App id ").EndInit();
        }

        protected override void OnStart()
        {
            OneSignal.Current.RegisterForPushNotifications();
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}

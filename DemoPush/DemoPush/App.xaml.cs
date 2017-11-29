using Com.OneSignal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace DemoPush
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new DemoPush.MainPage();

            OneSignal.Current.StartInit("6f02ec21-5c85-4674-9669-2c143a1dcff9").EndInit();
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

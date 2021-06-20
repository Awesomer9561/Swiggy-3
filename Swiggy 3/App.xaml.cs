using Swiggy_3.Pages.Login_Page;
using Swiggy_3.Pages.ShellPages;
using Swiggy_3.Pages.SplashScreen;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Swiggy_3
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new NavigationPage(new Loin_Page());
            //MainPage = new HomePage();
            App.Current.MainPage = new NavigationPage(new SplashScreen());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}

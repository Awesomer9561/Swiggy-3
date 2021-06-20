using Swiggy_3.Pages.ShellPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Swiggy_3.Pages.Login_Page;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Swiggy_3.Pages.SplashScreen
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SplashScreen : ContentPage
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await splashscreen.ScaleTo(100, 0);

            await Task.Delay(1500);
            await splashscreen.ScaleTo(20, 700, easing: Easing.Linear);

            await Task.Delay(1000);
            await splashscreen.ScaleTo(1, 200, easing: Easing.BounceOut);

            //App.Current.MainPage = new HomePage();
            App.Current.MainPage = new NavigationPage(new Loin_Page());
        }
    }
}
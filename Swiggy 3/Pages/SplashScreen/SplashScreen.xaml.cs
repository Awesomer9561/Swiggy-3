using Swiggy_3.Pages.Login_Page;
using Swiggy_3.Pages.ShellPages;
using System.Threading.Tasks;
using Xamarin.Essentials;
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
            await splashscreen.ScaleTo(40, 0);

            await Task.Delay(1000);
            await splashscreen.ScaleTo(1, 1000, easing: Easing.Linear);

            await Task.Delay(2000);
            await splashscreen.ScaleTo(1, 100, easing: Easing.Linear);
            //App.Current.MainPage = new HomePage();
            //App.Current.MainPage = new NavigationPage(new Loin_Page());

            if (Preferences.Get("LoggedIn", false) == true)
            {
                App.Current.MainPage = new HomePage();
            }
            else
            {
                App.Current.MainPage = new NavigationPage(new Loin_Page());
            }



        }
    }
}
using Swiggy_3.Models;
using Swiggy_3.Ulities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Swiggy_3.Pages.ShellPages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : Shell
    {

        public HomePage()
        {
            InitializeComponent();

            
            Routing.RegisterRoute("profile", typeof(Profile));
            Routing.RegisterRoute("loginPage", typeof(Login_Page.Loin_Page));
        }
        private void logout(object sender, EventArgs e)
        {
            AppUtilities.Logout();
            DisplayAlert("You have been logged out", "Please close the app and restart to login", "Ok");
        }


    }
}
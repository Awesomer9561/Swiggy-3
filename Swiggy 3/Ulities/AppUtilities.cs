using Swiggy_3.Pages.Login_Page;
using Swiggy_3.Pages.ShellPages;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Swiggy_3.Ulities
{
    class AppUtilities
    {
        public AppUtilities()
        {
            Preferences.Set("LoggedIn", false);
            
        }
        public static void Logout()
        {
            Preferences.Clear();
            //Shell.Current.GoToAsync(loginPage);
        }
    }
}

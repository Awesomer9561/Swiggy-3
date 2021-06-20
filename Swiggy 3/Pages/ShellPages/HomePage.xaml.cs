using System;
using System.Collections.Generic;
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
            Routing.RegisterRoute("swiggy", typeof(Swiggy));
            Routing.RegisterRoute("search", typeof(SearchPage));
            Routing.RegisterRoute("cart", typeof(Cart));
            Routing.RegisterRoute("profile", typeof(Profile));
            Routing.RegisterRoute("loginPage", typeof(Login_Page.Loin_Page));
        }
    }
}
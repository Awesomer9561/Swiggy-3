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
    public partial class Cart : ContentPage
    {
        public Cart()
        {
            InitializeComponent();
        }

        private void gotoSwiggyPage(object sender, EventArgs e)
        {
            //Shell.Current.GoToAsync("swiggy");
        }
    }
}
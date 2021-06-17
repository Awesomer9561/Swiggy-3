using Swiggy_3.Pages.ShellPages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Swiggy_3
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void gotoHomePage(object sender, EventArgs e)
        {
            App.Current.MainPage = new HomePage();
        }

       
    }
}

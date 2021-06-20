using Swiggy_3.Pages.ShellPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Swiggy_3.Pages.Login_Page
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Loin_Page : CarouselPage
    {
        public Loin_Page()
        {
            InitializeComponent();
        }

        private void Verify(object sender, EventArgs e)
        {
            CarousalLoginPage.CurrentPage = verify;
        }

        private void gotoHomePage(object sender, EventArgs e)
        {
            App.Current.MainPage = new HomePage();
        }
    }
}
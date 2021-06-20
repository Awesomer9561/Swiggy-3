using Swiggy_3.Pages.ShellPages;
using Swiggy_3.Ulities;
using System;
using Xamarin.Essentials;
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
            int otp0 = Convert.ToInt16(entry0.Text);
            int otp1 = Convert.ToInt16(entry1.Text);
            int otp2 = Convert.ToInt16(entry2.Text);
            int otp3 = Convert.ToInt16(entry3.Text);
            int otp4 = Convert.ToInt16(entry4.Text);
            int otp5 = Convert.ToInt16(entry5.Text);

            int totalOTP = otp0 + otp1 + otp2 + otp3 + otp4 + otp5;
            
            if(totalOTP != 21)
            {
                DisplayAlert("Incorrect OTP", "Please enter '123456'", "Ok");
                Preferences.Set("LoggedIn", false);
            }
            else
            {
                Preferences.Set("LoggedIn", true);
                App.Current.MainPage = new HomePage();
            }

        }
        

    }
}
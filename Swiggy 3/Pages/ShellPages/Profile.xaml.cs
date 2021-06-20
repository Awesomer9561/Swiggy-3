using Swiggy_3.Models;
using Swiggy_3.Ulities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Swiggy_3.Pages.ShellPages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Profile : ContentPage
    {
        ObservableCollection<ProfileOption> profileOptions { get; set; }
        ObservableCollection<Orders> order{ get; set; }
        public Profile()
        {
            InitializeComponent();
            setProfileData();
            setOrderData();
        }

        private void setOrderData()
        {
            order = new ObservableCollection<Orders>();
            order.Add(new Orders { Store = "Store Name" });
            order.Add(new Orders { Store = "Store Name" });
            order.Add(new Orders { Store = "Store Name" });
            order.Add(new Orders { Store = "Store Name" });
            order.Add(new Orders { Store = "Store Name" });
            order.Add(new Orders { Store = "Store Name" });
            order.Add(new Orders { Store = "Store Name" });
            PastOrders.ItemsSource = order;
        }

        private void setProfileData()
        {
            profileOptions = new ObservableCollection<ProfileOption>();
            profileOptions.Add(new ProfileOption
            {
                OptionName = "My Account",
                OptionDesc = "Addresses, Favourites and Offers"
            });
            profileOptions.Add(new ProfileOption
            {
                OptionName = "Payments and Refunds",
                OptionDesc = "Refund Status and Payment Modes"
            });
            profileOptions.Add(new ProfileOption
            {
                OptionName = "SWIGGY SUPER",
                OptionDesc = "Enjoy Free Delivery and Buy 1 Get 1 Free"
            });
            profileOptions.Add(new ProfileOption
            {
                OptionName = "Swiggy Money",
                OptionDesc = "View Account Balance and Transaction History"
            });
            profileOptions.Add(new ProfileOption
            {
                OptionName = "Help",
                OptionDesc = "FAQ's and Links"
            });
        }

        private void logout(object sender, EventArgs e)
        {
            AppUtilities.Logout();
            DisplayAlert("You have been logged out", "Please close the app and restart to login", "Ok");
        }
    }
}
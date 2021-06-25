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
        //ObservableCollection<ProfileOption> profileOptions { get; set; }
        ObservableCollection<Orders> order{ get; set; }
       
        public Profile()
        {
            InitializeComponent();
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

        private void logout(object sender, EventArgs e)
        {
            //AppUtilities.Logout();
            DisplayAlert("You have been logged out", "Please close the app and restart to login", "Ok");
        }

    }
}
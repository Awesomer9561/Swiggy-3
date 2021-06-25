using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Swiggy_3.Pages.Flyout_Templates
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class orderCarouseltemp : ContentView
    {
        ObservableCollection<string> order { get; set; }

        public orderCarouseltemp()
        {
            InitializeComponent();
            setOrderData();
        }

        private void setOrderData()
        {
            order = new ObservableCollection<string>();
            order.Add("Store Name");
            order.Add("Store Name");
            order.Add("Store Name");
            order.Add("Store Name");
            order.Add("Store Name");
            order.Add("Store Name");
            order.Add("Store Name");
            order.Add("Store Name");

            Orders.ItemsSource = order;
        }
    }
}
using Swiggy_3.Models;
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
    public partial class Swiggy : ContentPage
    {
        ObservableCollection<Models.CategoriesCollection> categories { get; set; }
        ObservableCollection<Brands> brands1 { get; set; }
        ObservableCollection<string> lstOfoffferCarosalData { get; set; }
        ObservableCollection<TopPicks> topPicksImage { get; set; }
        public Swiggy()
        {
            InitializeComponent();
            setCategoryData();
            //SetOfferCarosaleData();
            setBrandInfo1();
            setTopPickImage();
        }
        string time = "mins";
        private void setBrandInfo1()
        {
            brands1 = new ObservableCollection<Brands>();
            brands1.Add(new Brands
            {
                brandImage = "mcdlogo.jpg",
                brandName = "McDonald's",
                Time = "10" + time
            });
            brands1.Add(new Brands
            {
                brandImage = "logo1.jpg",
                brandName = "The Bowl\nCompany",
                Time = "14" + time
            });
            brands1.Add(new Brands
            {
                brandImage = "logo2.jpg",
                brandName = "Domino's",
                Time = "15" + time
            });
            brands1.Add(new Brands
            {
                brandImage = "logo3.jpg",
                brandName = "KFC",
                Time = "20" + time
            });
            brands1.Add(new Brands
            {
                brandImage = "logo4.jpg",
                brandName = "Subway",
                Time = "35" + time
            });
            brands1.Add(new Brands
            {
                brandImage = "logo3.jpg",
                brandName = "KFC",
                Time = "20" + time
            });
            brands1.Add(new Brands
            {
                brandImage = "logo4.jpg",
                brandName = "Subway",
                Time = "35" + time
            });
            brands1.Add(new Brands
            {
                brandImage = "logo1.jpg",
                brandName = "The Bowl\nCompany",
                Time = "14" + time
            });
            brands1.Add(new Brands
            {
                brandImage = "mcdlogo.jpg",
                brandName = "McDonald's",
                Time = "10" + time
            });
            brands1.Add(new Brands
            {
                brandImage = "logo2.jpg",
                brandName = "Domino's",
                Time = "15" + time
            });
            
            BrandCollection1.ItemsSource = brands1;
        }
        private void setTopPickImage()
        {
            topPicksImage = new ObservableCollection<TopPicks>();
            topPicksImage.Add(new TopPicks
            {
                foodImage = "food1.jpg",
                foodName = "food1",
                Time = "19" + time
            });
            topPicksImage.Add(new TopPicks
            {
                foodImage = "food2.jpg",
                foodName = "food2",
                Time = "19" + time
            });
            topPicksImage.Add(new TopPicks
            {
                foodImage = "food3.jpg",
                foodName = "food3",
                Time = "19" + time
            }); 
            topPicksImage.Add(new TopPicks
            {
                foodImage = "food4.jpg",
                foodName = "food4",
                Time = "19" + time
            });
            topPicksImage.Add(new TopPicks
            {
                foodImage = "food1.jpg",
                foodName = "food1",
                Time = "19" + time
            });
            topPicksImage.Add(new TopPicks
            {
                foodImage = "food2.jpg",
                foodName = "food2",
                Time = "19" + time
            });
            topPicksImage.Add(new TopPicks
            {
                foodImage = "food3.jpg",
                foodName = "food3",
                Time = "19" + time
            });
            topPicksImage.Add(new TopPicks
            {
                foodImage = "food4.jpg",
                foodName = "food4",
                Time = "19" + time
            });
            topPicksImage.Add(new TopPicks
            {
                foodImage = "food1.jpg",
                foodName = "food1",
                Time = "19" + time
            });
            topPicksImage.Add(new TopPicks
            {
                foodImage = "food2.jpg",
                foodName = "food2",
                Time = "19" + time
            });
            
            TopPickCollection.ItemsSource = topPicksImage;
        }

        /*private void SetOfferCarosaleData()
        {
            lstOfoffferCarosalData = new ObservableCollection<string>();
            lstOfoffferCarosalData.Add("* 100+ OUT LET WITH GREAT DISCOUNTS");
            lstOfoffferCarosalData.Add("* 200+ OUT LET WITH GREAT DISCOUNTS");
            lstOfoffferCarosalData.Add("* 400+ OUT LET WITH GREAT DISCOUNTS");
            lstOfoffferCarosalData.Add("* 600+ OUT LET WITH GREAT DISCOUNTS");
            carousalOffers.ItemsSource = lstOfoffferCarosalData;

        }*/
        private void setCategoryData()
        {
            categories = new ObservableCollection<Models.CategoriesCollection>();
            categories.Add(new CategoriesCollection
            {
                CategoryName = "Genie",
                CategoryImage = "Genie.jpg",
                Description = "Anything you need,\ndelivered"
            });
            categories.Add(new CategoriesCollection
            {
                CategoryName = "Restaurants",
                CategoryImage = "restaurants.png",
                Description = "Enjoy your\nfavourite meals"
            });
            categories.Add(new CategoriesCollection
            {
                CategoryName = "Genie",
                CategoryImage = "Genie.jpg",
                Description = "Anything you need,\ndelivered"
            });
            categories.Add(new CategoriesCollection
            {
                CategoryName = "Restaurants",
                CategoryImage = "restaurants.png",
                Description = "Enjoy your\nfavourite meals"
            });
            categories.Add(new CategoriesCollection
            {
                CategoryName = "Healthy",
                CategoryImage = "healthy.png",
                Description = "For your kind\nof healthy"
            }); 
            categories.Add(new CategoriesCollection
            {
                CategoryName = "Genie",
                CategoryImage = "Genie.jpg",
                Description = "Anything you need,\ndelivered"
            });
            categories.Add(new CategoriesCollection
            {
                CategoryName = "Restaurants",
                CategoryImage = "restaurants.png",
                Description = "Enjoy your\nfavourite meals"
            });
            categories.Add(new CategoriesCollection
            {
                CategoryName = "Healthy",
                CategoryImage = "healthy.png",
                Description = "For your kind\nof healthy"
            }); 
            categories.Add(new CategoriesCollection
            {
                CategoryName = "Genie",
                CategoryImage = "Genie.jpg",
                Description = "Anything you need,\ndelivered"
            });
            categories.Add(new CategoriesCollection
            {
                CategoryName = "Restaurants",
                CategoryImage = "restaurants.png",
                Description = "Enjoy your\nfavourite meals"
            });
            categories.Add(new CategoriesCollection
            {
                CategoryName = "Healthy",
                CategoryImage = "healthy.png",
                Description = "For your kind\nof healthy"
            });
            categories.Add(new CategoriesCollection
            {
                CategoryName = "Genie",
                CategoryImage = "Genie.jpg",
                Description = "Anything you need,\ndelivered"
            });
            categories.Add(new CategoriesCollection
            {
                CategoryName = "Restaurants",
                CategoryImage = "restaurants.png",
                Description = "Enjoy your\nfavourite meals"
            });
            categories.Add(new CategoriesCollection
            {
                CategoryName = "Healthy",
                CategoryImage = "healthy.png",
                Description = "For your kind\nof healthy"
            });

            CategoryColumn.ItemsSource = categories;
        }

        private void CategorySelected(object sender, SelectionChangedEventArgs e)
        {

        }

        /*protected override void OnAppearing()
        {
            base.OnAppearing();
            Device.StartTimer(TimeSpan.FromSeconds(5), (Func<bool>)(() =>
            {
                carousalOffers.Position = (carousalOffers.Position + 1) % lstOfoffferCarosalData.Count;
                return true;
            }));
        }*/
    }
}
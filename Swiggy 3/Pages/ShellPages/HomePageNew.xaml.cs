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
    public partial class HomePageNew : ContentPage
    {
        ObservableCollection<searchCategory> searchCategory { get; set; }
        ObservableCollection<popularCuisines> cuisineCollection { get; set; }
        ObservableCollection<CategoriesCollection> categories { get; set; }
        ObservableCollection<Brands> brands1 { get; set; }
        ObservableCollection<popularCuration> curations { get; set; }
        ObservableCollection<string> lstOfoffferCarosalData { get; set; }
        ObservableCollection<string> featuredOffers { get; set; }
        ObservableCollection<TopPicks> topPicksImage { get; set; }

        string time = "mins";
        public HomePageNew()
        {
            InitializeComponent();

            //Search Page
            setCategoryData2();
            setCuisineData();

            //Swiggy Page
            setCategoryData();
            SetOfferCarosaleData();
            setBrandInfo1();
            setFeaturedOffers();
            setTopPickImage();
            setCurationData();
        }

        //Search Page
        private void setCategoryData2()
        {
            searchCategory = new ObservableCollection<searchCategory>();
            searchCategory.Add(new searchCategory
            {
                catframeBgColor = "yellow",
                catframeImage = "fruits.png",
                catframeDesc = "Fruits"
            });
            searchCategory.Add(new searchCategory
            {
                catframeBgColor = "orange",
                catframeImage = "drinks.png",
                catframeDesc = "Drinks"
            });
            searchCategory.Add(new searchCategory
            {
                catframeBgColor = "white",
                catframeImage = "chips.png",
                catframeDesc = "Chips"
            });
            searchCategory.Add(new searchCategory
            {
                catframeBgColor = "yellow",
                catframeImage = "fruits.png",
                catframeDesc = "Fruits"
            });
            searchCategory.Add(new searchCategory
            {
                catframeBgColor = "orange",
                catframeImage = "drinks.png",
                catframeDesc = "Drinks"
            });
            searchCategory.Add(new searchCategory
            {
                catframeBgColor = "white",
                catframeImage = "chips.png",
                catframeDesc = "Chips"
            });
            searchCategory.Add(new searchCategory
            {
                catframeBgColor = "yellow",
                catframeImage = "fruits.png",
                catframeDesc = "Fruits"
            });
            searchCategory.Add(new searchCategory
            {
                catframeBgColor = "orange",
                catframeImage = "drinks.png",
                catframeDesc = "Drinks"
            });
            searchCategory.Add(new searchCategory
            {
                catframeBgColor = "white",
                catframeImage = "chips.png",
                catframeDesc = "Chips"
            });
            searchCategory.Add(new searchCategory
            {
                catframeBgColor = "yellow",
                catframeImage = "fruits.png",
                catframeDesc = "Fruits"
            });
            searchCategory.Add(new searchCategory
            {
                catframeBgColor = "orange",
                catframeImage = "drinks.png",
                catframeDesc = "Drinks"
            });
            searchCategory.Add(new searchCategory
            {
                catframeBgColor = "white",
                catframeImage = "chips.png",
                catframeDesc = "Chips"
            });
            CategoryCollectionView.ItemsSource = searchCategory;
        }
        private void setCuisineData()
        {
            cuisineCollection = new ObservableCollection<popularCuisines>();
            cuisineCollection.Add(new popularCuisines
            {
                cuisineImage = "fruits.png",
                cuisineName = "Fruits"
            });
            cuisineCollection.Add(new popularCuisines
            {
                cuisineImage = "fruits.png",
                cuisineName = "Fruits"
            });
            cuisineCollection.Add(new popularCuisines
            {
                cuisineImage = "fruits.png",
                cuisineName = "Fruits"
            });
            cuisineCollection.Add(new popularCuisines
            {
                cuisineImage = "fruits.png",
                cuisineName = "Fruits"
            });
            cuisineCollection.Add(new popularCuisines
            {
                cuisineImage = "fruits.png",
                cuisineName = "Fruits"
            });
            cuisineCollection.Add(new popularCuisines
            {
                cuisineImage = "fruits.png",
                cuisineName = "Fruits"
            });
            cuisineCollection.Add(new popularCuisines
            {
                cuisineImage = "fruits.png",
                cuisineName = "Fruits"
            });
            cuisineCollection.Add(new popularCuisines
            {
                cuisineImage = "fruits.png",
                cuisineName = "Fruits"
            });
            cuisineCollection.Add(new popularCuisines
            {
                cuisineImage = "fruits.png",
                cuisineName = "Fruits"
            });
            cuisineCollection.Add(new popularCuisines
            {
                cuisineImage = "fruits.png",
                cuisineName = "Fruits"
            });
            CuisineCollectionView.ItemsSource = cuisineCollection;
        }

        //Swiggy Page
        private void setFeaturedOffers()
        {
            featuredOffers = new ObservableCollection<string>();
            featuredOffers.Add("offer1.jpg");
            featuredOffers.Add("offer2.jpg");
            featuredOffers.Add("offer3.jpg");
            featuredOffers.Add("offer3.jpg");
            featuredOffers.Add("offer4.jpg");
            featuredOffers.Add("offer5.png");
            featuredOffers.Add("offer3.jpg");
            featuredOffers.Add("offer5.png");
            featuredOffers.Add("offer4.jpg");
            featuredOffers.Add("offer1.jpg");
            featuredOfferCarousalView.ItemsSource = featuredOffers;
        }
        private void setCurationData()
        {
            curations = new ObservableCollection<popularCuration>();
            curations.Add(new popularCuration
            {
                foodImage = "foodBiryani.png",
                foodName = "Biryani"
            });
            curations.Add(new popularCuration
            {
                foodImage = "foodChinese.png",
                foodName = "Chinese"
            });
            curations.Add(new popularCuration
            {
                foodImage = "foodPizza.png",
                foodName = "Pizza"
            });
            curations.Add(new popularCuration
            {
                foodImage = "foodVegBirani.png",
                foodName = "Veg Biryani"
            });
            curations.Add(new popularCuration
            {
                foodImage = "foodBiryani.png",
                foodName = "Biryani"
            });
            curations.Add(new popularCuration
            {
                foodImage = "foodChinese.png",
                foodName = "Chinese"
            });
            curations.Add(new popularCuration
            {
                foodImage = "foodPizza.png",
                foodName = "Pizza"
            });
            curations.Add(new popularCuration
            {
                foodImage = "foodBiryani.png",
                foodName = "Biryani"
            });
            curations.Add(new popularCuration
            {
                foodImage = "foodChinese.png",
                foodName = "Chinese"
            });
            curations.Add(new popularCuration
            {
                foodImage = "foodPizza.png",
                foodName = "Pizza"
            });
            curations.Add(new popularCuration
            {
                foodImage = "foodVegBirani.png",
                foodName = "Veg Biryani"
            });
            curations.Add(new popularCuration
            {
                foodImage = "foodBiryani.png",
                foodName = "Biryani"
            });
            curations.Add(new popularCuration
            {
                foodImage = "foodChinese.png",
                foodName = "Chinese"
            });
            curations.Add(new popularCuration
            {
                foodImage = "foodPizza.png",
                foodName = "Pizza"
            });
            
            popularCurations.ItemsSource = curations;
        }
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
            somethingNewCollectionView.ItemsSource = topPicksImage;
        }

        private void SetOfferCarosaleData()
        {
            lstOfoffferCarosalData = new ObservableCollection<string>();
            lstOfoffferCarosalData.Add("* 100+ OUT LET WITH GREAT DISCOUNTS");
            lstOfoffferCarosalData.Add("* 200+ OUT LET WITH GREAT DISCOUNTS");
            lstOfoffferCarosalData.Add("* 400+ OUT LET WITH GREAT DISCOUNTS");
            lstOfoffferCarosalData.Add("* 600+ OUT LET WITH GREAT DISCOUNTS");
            carousalOffers.ItemsSource = lstOfoffferCarosalData;

        }
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
        private void instamart(object sender, EventArgs e)
        {

        }

        //Cart
        private void gotoSwiggyPage(object sender, EventArgs e)
        {
           
        }

        //protected override void OnAppearing()
        //{
        //    base.OnAppearing();
        //    Device.StartTimer(TimeSpan.FromSeconds(5), (Func<bool>)(() =>
        //    {
        //        carousalOffers.Position = (carousalOffers.Position + 1) % lstOfoffferCarosalData.Count;
        //        return true;
        //    }));
        //}
    }
}
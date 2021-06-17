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
            SetOfferCarosaleData();
            setBrandInfo1();
            setTopPickImage();
        }
        string time = "mins";
        private void setBrandInfo1()
        {
            brands1 = new ObservableCollection<Brands>();
            brands1.Add(new Brands
            {
                brandImage = "food.jpg",
                brandName = "McDonald's",
                Time = "10" + time
            });
            brands1.Add(new Brands
            {
                brandImage = "mcdlogo.jpg",
                brandName = "McDonald's",
                Time = "10" + time
            });
            brands1.Add(new Brands
            {
                brandImage = "mcdlogo.jpg",
                brandName = "McDonald's",
                Time = "10" + time
            });
            brands1.Add(new Brands
            {
                brandImage = "mcdlogo.jpg",
                brandName = "McDonald's",
                Time = "10" + time
            });
            brands1.Add(new Brands
            {
                brandImage = "mcdlogo.jpg",
                brandName = "McDonald's",
                Time = "10" + time
            });
            brands1.Add(new Brands
            {
                brandImage = "mcdlogo.jpg",
                brandName = "McDonald's",
                Time = "10" + time
            });
            brands1.Add(new Brands
            {
                brandImage = "mcdlogo.jpg",
                brandName = "McDonald's",
                Time = "10" + time
            });
            BrandCollection1.ItemsSource = brands1;
        }
        private void setTopPickImage()
        {
            topPicksImage = new ObservableCollection<TopPicks>();
            topPicksImage.Add(new TopPicks
            {
                foodImage = "food.jpg",
                foodName = "Burgers",
                Time = "19" + time
            });
            topPicksImage.Add(new TopPicks
            {
                foodImage = "food.jpg",
                foodName = "Burgers",
                Time = "19" + time
            });
            topPicksImage.Add(new TopPicks
            {
                foodImage = "food.jpg",
                foodName = "Burgers",
                Time = "19" + time
            }); 
            topPicksImage.Add(new TopPicks
            {
                foodImage = "food.jpg",
                foodName = "Burgers",
                Time = "19" + time
            }); 
            topPicksImage.Add(new TopPicks
            {
                foodImage = "food.jpg",
                foodName = "Burgers",
                Time = "19" + time
            }); 
            topPicksImage.Add(new TopPicks
            {
                foodImage = "food.jpg",
                foodName = "Burgers",
                Time = "19" + time
            }); 
            topPicksImage.Add(new TopPicks
            {
                foodImage = "food.jpg",
                foodName = "Burgers",
                Time = "19" + time
            });
            topPicksImage.Add(new TopPicks
            {
                foodImage = "food.jpg",
                foodName = "Burgers",
                Time = "19" + time
            });
            topPicksImage.Add(new TopPicks
            {
                foodImage = "food.jpg",
                foodName = "Burgers",
                Time = "19" + time
            }); 
            topPicksImage.Add(new TopPicks
            {
                foodImage = "food.jpg",
                foodName = "Burgers",
                Time = "19" + time
            });
            topPicksImage.Add(new TopPicks
            {
                foodImage = "food.jpg",
                foodName = "Burgers",
                Time = "19" + time
            });
            TopPickCollection.ItemsSource = topPicksImage;
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
                CategoryName = "Category",
                CategoryImage = "Category.jpg",
                Description = "Description"
            });
            categories.Add(new CategoriesCollection
            {
                CategoryName = "Category",
                CategoryImage = "Category.jpg",
                Description = "Description"
            });
            categories.Add(new CategoriesCollection
            {
                CategoryName = "Category",
                CategoryImage = "Category.jpg",
                Description = "Description"
            });
            categories.Add(new CategoriesCollection
            {
                CategoryName = "Category",
                CategoryImage = "Category.jpg",
                Description = "Description"
            });
            categories.Add(new CategoriesCollection
            {
                CategoryName = "Category",
                CategoryImage = "Category.jpg",
                Description = "Description"
            });
            categories.Add(new CategoriesCollection
            {
                CategoryName = "Category",
                CategoryImage = "Category.jpg",
                Description = "Description"
            });
            categories.Add(new CategoriesCollection
            {
                CategoryName = "Category",
                CategoryImage = "Category.jpg",
                Description = "Description"
            });
            categories.Add(new CategoriesCollection
            {
                CategoryName = "Category",
                CategoryImage = "Category.jpg",
                Description = "Description"
            });
            categories.Add(new CategoriesCollection
            {
                CategoryName = "Category",
                CategoryImage = "Category.jpg",
                Description = "Description"
            });
            categories.Add(new CategoriesCollection
            {
                CategoryName = "Category",
                CategoryImage = "Category.jpg",
                Description = "Description"
            });
            categories.Add(new CategoriesCollection
            {
                CategoryName = "Category",
                CategoryImage = "Category.jpg",
                Description = "Description"
            });
            CategoryColumn.ItemsSource = categories;
        }

        private void CategorySelected(object sender, SelectionChangedEventArgs e)
        {

        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            Device.StartTimer(TimeSpan.FromSeconds(5), (Func<bool>)(() =>
            {
                carousalOffers.Position = (carousalOffers.Position + 1) % lstOfoffferCarosalData.Count;
                return true;
            }));
        }
    }
}
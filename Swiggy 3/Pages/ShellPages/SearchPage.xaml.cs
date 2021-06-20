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
    public partial class SearchPage : ContentPage
    {
        ObservableCollection<searchCategory> searchCategory { get; set; }
        ObservableCollection<popularCuisines> cuisineCollection { get; set; }
        public SearchPage()
        {
            InitializeComponent();
            setCategoryData();
            setCuisineData();

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

        private void setCategoryData()
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
    }
}
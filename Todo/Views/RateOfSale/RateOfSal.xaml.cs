using System;
using System.Diagnostics;
using Xamarin.Forms;

namespace Todo
{
    public partial class RateOfSal: ContentPage
    {
        public RateOfSal()

        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            listView.ItemsSource = await App.Database5.GetItemsNotDoneAsync();
            
        }

    }
}

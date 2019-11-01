using System;
using Todo.Models;
using Xamarin.Forms;

namespace Todo
{
	public partial class BuyerMenu : ContentPage
	{
		public BuyerMenu()


		{
			InitializeComponent();
		}

        async void Button_Clicked(object sender, EventArgs e)
        {
            //await Navigation.PushAsync(new AuthOne());
            await Navigation.PushAsync(new StocksListPage());
        }

        private async void Button_Clicked_2(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CameraListPage());
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CalendarListPage2());
        }
    }
}

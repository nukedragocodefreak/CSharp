using System;
using Todo.Models;
using Xamarin.Forms;

namespace Todo
{
	public partial class Login1 : ContentPage
	{
		public Login1()

		{
			InitializeComponent();
		}

        private async void Button_Clicked_2(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CalendarListPage());
        }

        private async void Button_Clicked_4(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BuyerLogin());
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LoginMenu());
        }
    }
}

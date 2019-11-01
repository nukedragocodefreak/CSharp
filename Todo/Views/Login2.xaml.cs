using System;
using Todo.Models;
using Xamarin.Forms;

namespace Todo
{
	public partial class Login2 : ContentPage
	{
		public Login2()


		{
			InitializeComponent();
		}
        async void OnSaveClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CustomersListPage());
        }

        async void Button_Clicked_1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BuyersListPage());
        }

        private async void Button_Clicked_2(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CalendarListPage1());
        }

        private async void Button_Clicked_3(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RegisterListPage());
        }

        private async void Button_Clicked_5(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NumDistri());
        }

        private async void Button_Clicked_6(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RateOfSal());
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Routes());
        }

        private async void Button_Clicked_4(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new LoginMenu());
        }
    }
}

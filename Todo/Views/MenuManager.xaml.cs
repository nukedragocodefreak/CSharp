using System;
using Xamarin.Forms;

namespace Todo
{
	public partial class MenuManager : ContentPage
	{
		public MenuManager()
		{
			InitializeComponent();
            Application application = new Application();

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

        private async void Button_Clicked_4(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AuthOne());
        }

        private async void Button_Clicked_5(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NumDistribution());
        }

        private async void Button_Clicked_6(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RateOfSal());
        }
    }
}

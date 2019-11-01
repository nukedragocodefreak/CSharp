using System;
using Xamarin.Forms;

namespace Todo
{
	public partial class Menu : ContentPage
	{
		public Menu()
		{
			InitializeComponent();
            Application application = new Application();

		}

        private async void Button_Clicked(object sender, EventArgs e) {

            await Navigation.PushAsync(new CustomersItemPage());      
        }

        private async void Button_Clicked_2(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new CalendarItemPage());
        }

        private async void Button_Clicked_4(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new StocksItemPage());
        }
    }
}

using System;
using System.Diagnostics;
using Todo.Models;
using Xamarin.Forms;

namespace Todo
{
	public partial class StocksListPage : ContentPage
	{
		public StocksListPage()
		{
			InitializeComponent();
		}

		protected override async void OnAppearing()
		{
			base.OnAppearing();

			// Reset the 'resume' id, since we just want to re-start here
			((App)App.Current).ResumeAtTodoId = -1;
			listView.ItemsSource = await App.Database5.GetItemsAsync();
		}

		async void OnItemAdded(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new StocksItemPage
            {
				BindingContext = new Stocks()
			});
		}

		async void OnListItemSelected(object sender, SelectedItemChangedEventArgs e)
		{
            //((App)App.Current).ResumeAtTodoId = (e.SelectedItem as TodoItem).ID;
            //Debug.WriteLine("setting ResumeAtTodoId = " + (e.SelectedItem as TodoItem).ID);
            if (e.SelectedItem != null)
            {
                await Navigation.PushAsync(new StocksItemPage
                {
                    BindingContext = e.SelectedItem as Stocks
                });
            }
		}

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CalendarListPage2());
            //await Navigation.PushAsync(new Login1());
        }
    }
}

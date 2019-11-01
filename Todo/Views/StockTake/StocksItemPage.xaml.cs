using System;
using Todo.Models;
using Xamarin.Forms;

namespace Todo
{
	public partial class StocksItemPage : ContentPage
	{
		public StocksItemPage()
		{
			InitializeComponent();
            Rate.IsVisible = false;
            var data = App.Database3.GetItemsNotDoneAsync();
            if (data.Result.Count == 0)
            {
            }
            else
            {
                for (int a = 0; a < data.Result.Count; a++)
                {
                    String dat = data.Result[a].Name;
                    Picker1.Items.Add(dat);
                }

            }
        }

		async void OnSaveClicked(object sender, EventArgs e)
		{
            float a = float.Parse(DDelivered.Text);
            float b = float.Parse(Sold.Text);
            float c = float.Parse(Instock.Text);
            float d = b/a;
            Rate.Text = d.ToString();

            var todoItem = (Stocks)BindingContext;
			await App.Database5.SaveItemAsync(todoItem);
			await Navigation.PopAsync();
		}

		async void OnDeleteClicked(object sender, EventArgs e)
		{
			var todoItem = (Stocks)BindingContext;
			await App.Database5.DeleteItemAsync(todoItem);
			await Navigation.PopAsync();
		}

		async void OnCancelClicked(object sender, EventArgs e)
		{
			await Navigation.PopAsync();
		}
	}
}

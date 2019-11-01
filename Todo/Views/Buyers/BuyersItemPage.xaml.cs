using System;
using Todo.Models;
using Xamarin.Forms;

namespace Todo
{
	public partial class BuyersItemPage : ContentPage
	{
		public BuyersItemPage()
		{
			InitializeComponent();
		}

		async void OnSaveClicked(object sender, EventArgs e)
		{
			var todoItem = (Buyers)BindingContext;
			await App.Database2.SaveItemAsync(todoItem);
			await Navigation.PopAsync();
		}

		async void OnDeleteClicked(object sender, EventArgs e)
		{
			var todoItem = (Buyers)BindingContext;
			await App.Database2.DeleteItemAsync(todoItem);
			await Navigation.PopAsync();
		}

		async void OnCancelClicked(object sender, EventArgs e)
		{
			await Navigation.PopAsync();
		}
	}
}

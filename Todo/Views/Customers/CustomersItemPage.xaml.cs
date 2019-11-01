using System;
using Todo.Models;
using Xamarin.Forms;

namespace Todo
{
	public partial class CustomersItemPage : ContentPage
	{
		public CustomersItemPage()

		{
			InitializeComponent();
		}

		async void OnSaveClicked(object sender, EventArgs e)
		{
			var todoItem = (Customer)BindingContext;
			await App.Database3.SaveItemAsync(todoItem);
			await Navigation.PopAsync();
		}

		async void OnDeleteClicked(object sender, EventArgs e)
		{
			var todoItem = (Customer)BindingContext;
			await App.Database3.DeleteItemAsync(todoItem);
			await Navigation.PopAsync();
		}

		async void OnCancelClicked(object sender, EventArgs e)
		{
			await Navigation.PopAsync();
		}

	
	}
}

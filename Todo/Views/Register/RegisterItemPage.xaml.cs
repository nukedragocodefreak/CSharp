using System;
using Todo.Models;
using Xamarin.Forms;

namespace Todo
{
	public partial class RegisterItemPage : ContentPage
	{
		public RegisterItemPage()
		{
			InitializeComponent();
		}

		async void OnSaveClicked(object sender, EventArgs e)
		{
			var todoItem = (Register)BindingContext;
			await App.Database1.SaveItemAsync(todoItem);
			await Navigation.PopAsync();
		}

		async void OnDeleteClicked(object sender, EventArgs e)
		{
			var todoItem = (Register)BindingContext;
			await App.Database1.DeleteItemAsync(todoItem);
			await Navigation.PopAsync();
		}

		async void OnCancelClicked(object sender, EventArgs e)
		{
			await Navigation.PopAsync();
		}

	}
}

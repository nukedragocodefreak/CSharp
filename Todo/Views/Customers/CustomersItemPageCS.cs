﻿using Todo.Models;
using Xamarin.Forms;

namespace Todo
{
	public class CustomersItemPageCS : ContentPage
	{
		public CustomersItemPageCS()

		{
			Title = "Todo Item";

			var nameEntry = new Entry();
			nameEntry.SetBinding(Entry.TextProperty, "Name");

			var notesEntry = new Entry();
			notesEntry.SetBinding(Entry.TextProperty, "Description");


			var saveButton = new Button { Text = "Save" };
			saveButton.Clicked += async (sender, e) =>
			{
				var todoItem = (Customer)BindingContext;
				await App.Database3.SaveItemAsync(todoItem);
				await Navigation.PopAsync();
			};

			var deleteButton = new Button { Text = "Delete" };
			deleteButton.Clicked += async (sender, e) =>
			{
				var todoItem = (Customer)BindingContext;
				await App.Database3.DeleteItemAsync(todoItem);
				await Navigation.PopAsync();
			};

			var cancelButton = new Button { Text = "Cancel" };
			cancelButton.Clicked += async (sender, e) =>
			{
				await Navigation.PopAsync();
			};


			Content = new StackLayout
			{
				Margin = new Thickness(20),
				VerticalOptions = LayoutOptions.StartAndExpand,
				Children =
				{
					new Label { Text = "Name" },
					nameEntry,
					new Label { Text = "Description" },
					notesEntry,
					saveButton,
					deleteButton,
					cancelButton
				}
			};
		}
	}
}

﻿using System;
using System.Diagnostics;
using Todo.Models;
using Xamarin.Forms;

namespace Todo
{
	public class BuyersListPageCS : ContentPage
	{
		ListView listView;

		public BuyersListPageCS()

		{
			Title = "Todo";

			var toolbarItem = new ToolbarItem
			{
				Text = "+",
				IconImageSource = Device.RuntimePlatform == Device.iOS ? null : "plus.png"
			};
			toolbarItem.Clicked += async (sender, e) =>
			{
				await Navigation.PushAsync(new BuyersItemPageCS
				{
					BindingContext = new Buyers()
				});
			};
			ToolbarItems.Add(toolbarItem);

			listView = new ListView
			{
				Margin = new Thickness(20),
				ItemTemplate = new DataTemplate(() =>
				{
					var label = new Label
					{
						VerticalTextAlignment = TextAlignment.Center,
						HorizontalOptions = LayoutOptions.StartAndExpand
					};
					label.SetBinding(Label.TextProperty, "Name");

					var tick = new Image
					{
						Source = ImageSource.FromFile("check.png"),
						HorizontalOptions = LayoutOptions.End
					};
					//tick.SetBinding(VisualElement.IsVisibleProperty, "Done");

					var stackLayout = new StackLayout
					{
						Margin = new Thickness(20, 0, 0, 0),
						Orientation = StackOrientation.Horizontal,
						HorizontalOptions = LayoutOptions.FillAndExpand,
						Children = { label, tick }
					};

					return new ViewCell { View = stackLayout };
				})
			};
			listView.ItemSelected += async (sender, e) =>
			{
                //((App)App.Current).ResumeAtTodoId = (e.SelectedItem as TodoItem).ID;
                //Debug.WriteLine("setting ResumeAtTodoId = " + (e.SelectedItem as TodoItem).ID);

                if (e.SelectedItem != null)
                {
                    await Navigation.PushAsync(new BuyersItemPageCS
                    {
                        BindingContext = e.SelectedItem as Buyers
                    });
                }
			};

			Content = listView;
		}

		protected override async void OnAppearing()
		{
			base.OnAppearing();

			// Reset the 'resume' id, since we just want to re-start here
			((App)App.Current).ResumeAtTodoId = -1;
			listView.ItemsSource = await App.Database2.GetItemsAsync();
		}
	}
}

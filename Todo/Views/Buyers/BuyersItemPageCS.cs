using Todo.Models;
using Xamarin.Forms;

namespace Todo
{
	public class BuyersItemPageCS : ContentPage
	{
		public BuyersItemPageCS()

		{
			Title = "Todo Item";

			var usernameEntry = new Entry();
			usernameEntry.SetBinding(Entry.TextProperty, "UserName");		

            var nameEntry = new Entry();
            nameEntry.SetBinding(Entry.TextProperty, "Name");

            var phoneEntry = new Entry();
            phoneEntry.SetBinding(Entry.TextProperty, "Phone");

            var passEntry = new Entry();
            passEntry.SetBinding(Entry.TextProperty, "Password");
            //var doneSwitch = new Switch();
            //doneSwitch.SetBinding(Switch.IsToggledProperty, "Done");

            var saveButton = new Button { Text = "Save" };
			saveButton.Clicked += async (sender, e) =>
			{
				var todoItem = (Buyers)BindingContext;
				await App.Database2.SaveItemAsync(todoItem);
				await Navigation.PopAsync();
			};

			var deleteButton = new Button { Text = "Delete" };
			deleteButton.Clicked += async (sender, e) =>
			{
				var todoItem = ( Buyers)BindingContext;
				await App.Database2.DeleteItemAsync(todoItem);         
				await Navigation.PopAsync();
			};

			var cancelButton = new Button { Text = "Cancel" };
			cancelButton.Clicked += async (sender, e) =>
			{
				await Navigation.PopAsync();
			};

			var speakButton = new Button { Text = "Speak" };
			speakButton.Clicked += (sender, e) =>
			{
				var todoItem = (Buyers)BindingContext;
				DependencyService.Get<ITextToSpeech>().Speak(todoItem.Name + " " + todoItem.UserName);
			};

			Content = new StackLayout
			{
				Margin = new Thickness(20),
				VerticalOptions = LayoutOptions.StartAndExpand,
				Children =
				{
                    new Label { Text = "UserName" },
                    usernameEntry,
                    new Label { Text = "Name" },
					nameEntry,
					new Label { Text = "Phone" },
					phoneEntry,
					new Label { Text = "Password" },
                    passEntry,
					saveButton,
					deleteButton,
					cancelButton,
					speakButton
				}
			};
		}
	}
}

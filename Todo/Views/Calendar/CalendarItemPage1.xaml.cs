using System;
using Todo.Models;
using Xamarin.Forms;

namespace Todo
{
	public partial class CalendarItemPage1 : ContentPage
	{
		public CalendarItemPage1()

		{
			InitializeComponent();
            approve.Items.Add("Pending");
            approve.Items.Add("Yes");
            approve.Items.Add("No");
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
			var todoItem = (Calendar)BindingContext;
			await App.Database4.SaveItemAsync(todoItem);
			await Navigation.PopAsync();
		}

		async void OnDeleteClicked(object sender, EventArgs e)
		{
			var todoItem = (Calendar)BindingContext;
			await App.Database4.DeleteItemAsync(todoItem);
			await Navigation.PopAsync();
		}

		async void OnCancelClicked(object sender, EventArgs e)
		{
			await Navigation.PopAsync();
		}

	}
}

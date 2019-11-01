using System;
using Todo.Models;
using Xamarin.Forms;

namespace Todo
{
	public partial class CalendarItemPage : ContentPage
	{
		public CalendarItemPage()

		{
			InitializeComponent();
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

            var data1 = App.Database1.GetItemsNotDoneAsync();
            if (data1.Result.Count == 0)
            {
            }
            else
            {
                for (int a = 0; a < data1.Result.Count; a++)
                {
                    String dat1 = data1.Result[a].Name;
                    Picker2.Items.Add(dat1);
                }

            }
        }

		async void OnSaveClicked(object sender, EventArgs e)
		{
			var todoItem = (Calendar)BindingContext;
            todoItem.Approval = "Pending";
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

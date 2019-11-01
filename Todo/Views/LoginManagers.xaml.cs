using System;
using System.Net.Mail;
using Todo.Models;
using Xamarin.Forms;

namespace Todo
{
	public partial class LoginManagers : ContentPage
	{
		public LoginManagers()

		{
			InitializeComponent();
		}

		async void OnSaveClicked(object sender, EventArgs e)
		{
            String uname = UserName.Text;
            String pass = Password.Text;
            //var data = App.Database1.GetItemAsync1(uname, pass);
            //await Navigation.PopAsync();        
            if(uname.Equals("Admin") && pass.Equals("Admin123"))
            {
                //await DisplayAlert("Successful Login", "Welcome", "OK");
                await Navigation.PushAsync(new Login2());
            }
            //else if (uname != "Admin" || pass!= "Admin123")
            //{
            //    var data = App.Database7.GetItemAsync1(uname, pass);
            //    //await Navigation.PopAsync();        
            //    if (data.Result.Count == 0)
            //    {
            //        await DisplayAlert("Failed to Login", "Check Login Details", "OK");
            //    }
            //    else
            //    {
            //        await DisplayAlert("Successful Login", "Welcome", "OK");
            //        await Navigation.PushAsync(new Login2());
            //    }

            //}
            else if (uname==null && pass==null)
            {
                await DisplayAlert("Failed to Login", "Enter Login Details", "OK");

           }
            else
            {
                await DisplayAlert("Failed to Login", "Enter Login Details", "OK");

            }

        }


	}
}
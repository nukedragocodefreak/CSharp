using System;
using System.Net.Mail;
using Todo.Models;
using Xamarin.Forms;

namespace Todo
{
	public partial class BuyerLogin : ContentPage
	{
		public BuyerLogin()

		{
			InitializeComponent();
		}

		async void OnSaveClicked(object sender, EventArgs e)
		{
            String uname = UserName.Text;
            String pass = Password.Text;
            var data = App.Database2.GetItemAsync1(uname, pass);
            //await Navigation.PopAsync();        
            if(data.Result.Count==0)
            {             
                await DisplayAlert("Failed to Login", "Check Login Details", "OK");       
            }
            else
            {
                await DisplayAlert("Successful Login, Proceed", "Welcome", "OK");
                //await Navigation.PushAsync(new Login1());
                await Navigation.PushAsync(new InstoreListPage());
            }
           
        }


	}
}

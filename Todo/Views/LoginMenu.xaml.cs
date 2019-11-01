using System;
using Todo.Models;
using Xamarin.Forms;

namespace Todo
{
    public partial class LoginMenu : ContentPage
    {
        public LoginMenu()

        {
            InitializeComponent();
        }

        async void OnSaveClicked(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new LoginManagers());
        }

        async void Button_Clicked_1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Login());
        }

    }
}

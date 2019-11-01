using Plugin.Media;
using Plugin.Media.Abstractions;
using System;
using System.Net.Mail;
using Todo.Models;
using Xamarin.Forms;

namespace Todo
{
	public partial class Camera : ContentPage
	{
        string loc = null;
        public Camera()
	     {
			InitializeComponent();
          

            takePhoto.Clicked += async (sender, args) =>
            {
                if (!CrossMedia.Current.IsCameraAvailable || !CrossMedia.Current.IsTakePhotoSupported)
                {
                    DisplayAlert("No Camera", ":( No camera available.", "OK");
                    return;
                }

                var file = await CrossMedia.Current.TakePhotoAsync(new Plugin.Media.Abstractions.StoreCameraMediaOptions

                {
                    Directory = "Test",
                    SaveToAlbum = true,
                    CompressionQuality = 75,
                    CustomPhotoSize = 50,
                    PhotoSize = PhotoSize.MaxWidthHeight,
                    MaxWidthHeight = 2000,
                    DefaultCamera = CameraDevice.Front
                });

                if (file == null)
                    return;
                loc = file.Path;
                DisplayAlert("File Location", file.Path, "OK");


                image.Source = ImageSource.FromStream(() =>
                {
                    var stream = file.GetStream();
                    file.Dispose();
                    return stream;
                });
            };            
        }

        async void Button_Clicked(object sender, EventArgs e)
        {
            
            //var todoItem = (APhoto)BindingContext;
            APhoto photo = new APhoto
            {

                Name = "",
                Location = loc,
                Description = Notes.Text
            };
            await App.Database8.SaveItemAsync(photo);
            await Navigation.PopAsync();

        }

    }
}
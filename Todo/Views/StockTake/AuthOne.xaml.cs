using System;
using System.Net.Mail;
using Todo.Models;
using Xamarin.Forms;

namespace Todo
{
	public partial class AuthOne : ContentPage

	{
		public AuthOne()

		{
			InitializeComponent();
            var data = App.Database2.GetItemsNotDoneAsync();
            if (data.Result.Count == 0) {
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
            //await Navigation.PushAsync(new StocksListPage());
            try
            {
                Random random = new Random();
                int r = random.Next(100000, 900000);
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress("ncmangwarira@gmail.com");
                mail.To.Add("wibssales@gmail.com");
                mail.Subject = "Message Code";
                mail.Body = r.ToString();
                Verify verify = new Verify();
                verify.Passcode = r.ToString();
                var data = App.Database6.SaveItemAsync(verify);
                SmtpServer.Port = 587;
                SmtpServer.Host = "smtp.gmail.com";
                SmtpServer.EnableSsl = true;
                SmtpServer.UseDefaultCredentials = false;
                SmtpServer.Credentials = new System.Net.NetworkCredential("ncmangwarira@gmail.com", "Deli@flower123");
                SmtpServer.Send(mail);

                veri.IsVisible = true;
                Passcode.IsVisible = true;
                authcheck.IsVisible = true;

            }
            catch (Exception ex)
            {
                await DisplayAlert("Failed", ex.Message, "OK");

            }
          
        }
        async void OnSaveClicked1(object sender, EventArgs e)
        {
            String pcode = Passcode.Text;
            if (pcode == null)
            {
                await DisplayAlert("Field Is Empty", "Enter Passcode", "OK");
            }
            else
            {
                var data = App.Database6.GetItemsNotDoneAsync(pcode);
                //await Navigation.PopAsync();        
                if (data.Result.Count == 0)
                {
                    await DisplayAlert("Failed to Auntenticate", "Check The Passcode", "OK");
                }
                else
                {
                    await DisplayAlert("Successful Authentication", "Proceed", "OK");
                    //await Navigation.PushAsync(new AuthTwo());
                    await Navigation.PushAsync(new StocksListPage());
                }
            }

        }
    }
}

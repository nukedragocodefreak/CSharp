using System;
using System.Net.Mail;
using Todo.Models;
using Xamarin.Forms;

namespace Todo
{
	public partial class Routes : ContentPage
    {
        public Routes()

		{
			InitializeComponent();
            var data = App.Database4.GetItemsAsync1();
            var data1 = App.Database4.GetItemsAsync2();

            if (data.Result.Count == 0)
            {
            Total.Text = "0";
            TotalStores.Text = "0";
            }
            else
            {
                Total.Text = data.Result.Count.ToString();
                TotalStores.Text = data1.Result.Count.ToString();
                float a = data1.Result.Count;
                float b = data.Result.Count;
                float aa = a/b;
                float cc = 1 - aa;
                float dd = cc * 100;
                float bb = aa * 100;
                float dde = (float)Math.Round(aa * 100f) / 100f;
                float bbe = dde * 100;
                //float bba = (float)Math.Round(f * 100f) / 100f;
                NumDist.Text = bb.ToString() + "%";
               // ProgressBar progressBar = new ProgressBar { Progress = 0.5f };
                //Progress.Progress = 0.5f;
                progress.Progress = bbe;
                NumDist1.Text = dd.ToString() + "%";
                progress1.Progress = 1 - bbe;
                salesrep.Text = data.Result[0].SalesRep;

            }
        }

	}
}

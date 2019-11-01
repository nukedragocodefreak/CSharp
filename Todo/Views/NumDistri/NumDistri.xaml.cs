using System;
using System.Net.Mail;
using Todo.Models;
using Xamarin.Forms;

namespace Todo
{
	public partial class NumDistri : ContentPage
    { 
		public NumDistri()

		{
			InitializeComponent();
            var data = App.Database4.GetItemsAsync2();
            var data1 = App.Database4.GetItemsAsync3();

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
                float bb = aa * 100;
                NumDist.Text = bb.ToString() + "%";
               // ProgressBar progressBar = new ProgressBar { Progress = 0.5f };
                //Progress.Progress = 0.5f;
                progress.Progress = aa;

            }
        }

	}
}

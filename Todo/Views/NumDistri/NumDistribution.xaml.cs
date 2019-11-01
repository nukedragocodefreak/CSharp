using System;
using Todo.Models;
using Xamarin.Forms;
using OxyPlot.Xamarin.Forms;
namespace Todo
{
	public partial class NumDistribution : ContentPage
	{
        PieChartViewModel vm;
        public NumDistribution()
        {
            vm = new PieChartViewModel();
            InitializeComponent();
            this.BindingContext = vm;
        }

    }
}

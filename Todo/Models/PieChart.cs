using OxyPlot;
using OxyPlot.Series;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Todo.Models
{
    public class PieChart : INotifyPropertyChanged
    {


        private PlotModel pieModel { get; set; }

        public PlotModel PieModel
        {
            get
            {
                return pieModel;
            }
            set
            {
                pieModel = value;
            }
        }
        public ICommand btnPieGraph { get; set; }

        public PieChart()
        {
            btnPieGraph = new Command(LoadPieChart);

        }



        public void LoadPieChart()
        {
            PieModel = null;
            OnPropertyChanged("PieModel");
            var piemodel = new PlotModel { Title = "Numeric Distribution." };
            var ps = new PieSeries
            {
                StrokeThickness = 0.25,
                AngleSpan = 360,
                StartAngle = 0,
                InsideLabelFormat = "",
                OutsideLabelFormat = "{1}: {0}",
                TickHorizontalLength = 20,
                TickRadialLength = 2
            };

            ps.Slices.Add(new PieSlice("Rabbit", 33) { IsExploded = false, Fill = OxyColor.Parse("#3498db") });
            piemodel.Series.Add(ps);

            ps.Slices.Add(new PieSlice("Dog", 196) { IsExploded = false, Fill = OxyColor.Parse("#2ecc71") });
            piemodel.Series.Add(ps);

            ps.Slices.Add(new PieSlice("Cat", 152) { IsExploded = false, Fill = OxyColor.Parse("#9b59b6") });
            piemodel.Series.Add(ps);

            ps.Slices.Add(new PieSlice("Goldfish", 62) { IsExploded = false, Fill = OxyColor.Parse("#34495e") });
            piemodel.Series.Add(ps);

            ps.Slices.Add(new PieSlice("Hamster", 68) { IsExploded = false, Fill = OxyColor.Parse("#e74c3c") });
            piemodel.Series.Add(ps);

            ps.Slices.Add(new PieSlice("Birds", 101) { IsExploded = false, Fill = OxyColor.Parse("#f1c40f") });
            piemodel.Series.Add(ps);
            PieModel = piemodel;

            OnPropertyChanged("PieModel");
        }

        #region INotifyChangedProperties
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion INotifyChangedProperties
    }
}

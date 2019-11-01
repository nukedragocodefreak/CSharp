
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
    public class PieChartViewModel : INotifyPropertyChanged
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

        public PieChartViewModel()
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

            ps.Slices.Add(new PieSlice("OK Marimba", 33) { IsExploded = false, Fill = OxyColor.Parse("#3498db") });

            ps.Slices.Add(new PieSlice("OK Avondale", 196) { IsExploded = false, Fill = OxyColor.Parse("#2ecc71") });

            ps.Slices.Add(new PieSlice("OK Warren Park", 152) { IsExploded = false, Fill = OxyColor.Parse("#9b59b6") });

            ps.Slices.Add(new PieSlice("OK Glenora", 62) { IsExploded = false, Fill = OxyColor.Parse("#34495e") });

            ps.Slices.Add(new PieSlice("OK Town", 68) { IsExploded = false, Fill = OxyColor.Parse("#e74c3c") });

            ps.Slices.Add(new PieSlice("Choppies Marimba", 101) { IsExploded = false, Fill = OxyColor.Parse("#f1c40f") });
            ps.Slices.Add(new PieSlice("Choppies Avondale", 33) { IsExploded = false, Fill = OxyColor.Parse("#3498db") });

            ps.Slices.Add(new PieSlice("Choppies Mufakose", 196) { IsExploded = false, Fill = OxyColor.Parse("#2ecc71") });

            ps.Slices.Add(new PieSlice("Choppies Glenora", 152) { IsExploded = false, Fill = OxyColor.Parse("#9b59b6") });

            ps.Slices.Add(new PieSlice("Choppies Town", 62) { IsExploded = false, Fill = OxyColor.Parse("#34495e") });
            ps.Slices.Add(new PieSlice("SPAR Marimba", 33) { IsExploded = false, Fill = OxyColor.Parse("#3498db") });

            ps.Slices.Add(new PieSlice("SPAR Avondale", 196) { IsExploded = false, Fill = OxyColor.Parse("#2ecc71") });

            ps.Slices.Add(new PieSlice("SPAR Mufakose", 152) { IsExploded = false, Fill = OxyColor.Parse("#9b59b6") });

            ps.Slices.Add(new PieSlice("SPAR Glenora", 62) { IsExploded = false, Fill = OxyColor.Parse("#34495e") });

            ps.Slices.Add(new PieSlice("SPAR Town", 68) { IsExploded = false, Fill = OxyColor.Parse("#e74c3c") });

            ps.Slices.Add(new PieSlice("TM Marimba", 101) { IsExploded = false, Fill = OxyColor.Parse("#f1c40f") });
            ps.Slices.Add(new PieSlice("TM Avondale", 33) { IsExploded = false, Fill = OxyColor.Parse("#3498db") });

            ps.Slices.Add(new PieSlice("TM Mufakose", 196) { IsExploded = false, Fill = OxyColor.Parse("#2ecc71") });

            ps.Slices.Add(new PieSlice("TM Glenora", 152) { IsExploded = false, Fill = OxyColor.Parse("#9b59b6") });

            ps.Slices.Add(new PieSlice("TM Town", 62) { IsExploded = false, Fill = OxyColor.Parse("#34495e") });

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

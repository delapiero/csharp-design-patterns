using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obserwator
{
    public class ObserwatorA : IObserwator, INotifyPropertyChanged
    {
        public PlotModel Model { get; set; }

        public bool Aktywny { get; set; }

        public ObserwatorA()
        {
            Aktywny = true;
        }

        public void Aktualizuj(IObiektObserwowany o)
        {
            if (Aktywny)
            {
                Model = new PlotModel();

                IList<double> wartosci = (o as Obserwowany).wartosci;

                PieSeries series = new PieSeries();

                int size = wartosci.Count;
                for (int i = 0; i < size; ++i)
                {
                    // dodanie wartosci
                    series.Slices.Add(new PieSlice(((char)(65 + i)).ToString(),wartosci.ElementAt(i)));
                }

                Model.Series.Clear();
                Model.Series.Add(series);

                OnPropertyChanged("Model");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}

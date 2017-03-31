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
    public class ObserwatorB: IObserwator, INotifyPropertyChanged
    {
        public PlotModel Model { get; set; }

        public bool Aktywny { get; set; }

        public ObserwatorB()
        {
            Aktywny = true;
        }

        public void Aktualizuj(IObiektObserwowany o)
        {
            if (Aktywny)
            {
                Model = new PlotModel();

                IList<double> wartosci = (o as Obserwowany).wartosci;

                CategoryAxis osx = new CategoryAxis();
                LinearAxis osy = new LinearAxis();

                ColumnSeries series = new ColumnSeries();

                int size = wartosci.Count;
                for (int i = 0; i < size; ++i)
                {
                    // dodanie wartosci
                    series.Items.Add(
                        new ColumnItem(
                            wartosci.ElementAt(i),
                            i
                        ));
                    // dodanie kolumny
                    osx.Labels.Add(((char)(65 + i)).ToString());
                }

                Model.Axes.Add(osx);
                Model.Axes.Add(osy);
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

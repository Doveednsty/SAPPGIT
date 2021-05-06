using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SApp.Help_Classes
{
    public class Chart
    {
        public SeriesCollection SeriesCollection { get; set; }
        public string[] Labels { get; set; }
        public Func<double, string> YFormatter { get; set; }
        void m()
        {
            SeriesCollection = new SeriesCollection
            {
                new LineSeries
                {
                    // Title = (string) ChooseShareCB.SelectedItem,
                    Values = new ChartValues<double> { 14, 6, 5, 2, 4 } // вот тут должны быть значения акций --> ?LINQ?
                },

            };

            Labels = new[] { "Jan", "Feb", "Mar", "Apr", "May" };
            YFormatter = value => value.ToString("C");

            //modifying the series collection will animate and update the chart


            //modifying any series values will also animate and update the chart
            SeriesCollection[0].Values.Add(1001d);

            // DataContext = this;
        }
        

    }
}

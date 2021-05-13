using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SApp.Data
{
    public class Graphic
    {
        public string ChosenShare { get; set; }
        public SeriesCollection SeriesCollection { get; set; }
        public List<string> Labels { get; set; }
        public Func<double, string> YFormatter { get; set; }
        public void BuildChart()
        {

            SeriesCollection = new SeriesCollection
            {
                new LineSeries
                {
                    Title = ChosenShare,
                    Values = new ChartValues<double>()
                },

            };

            //Labels
            YFormatter = value => value.ToString("C");

            //modifying the series collection will animate and update the chart


            //modifying any series values will also animate and update the chart
            SeriesCollection[0].Values.Add(5d);

        }
    }
}

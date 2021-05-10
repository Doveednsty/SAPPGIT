using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SApp.Pages
{
    /// <summary>
    /// Логика взаимодействия для TrackingPage.xaml
    /// </summary>
    public partial class TrackingPage : Page
    {
        public TrackingPage()
        {
            InitializeComponent();
            List<string> lines = File.ReadAllLines(Directory.GetCurrentDirectory() + "/Data/Secidforcb.txt").ToList();
            ChooseShareCB.ItemsSource = lines;
        }

        public SeriesCollection SeriesCollection { get; set; }
        public string[] Labels { get; set; }
        public Func<double, string> YFormatter { get; set; }

        private void Trackingbtn_Click(object sender, RoutedEventArgs e)
        {
            SeriesCollection = new SeriesCollection
            {
                new LineSeries
                {
                    Title = (string)ChooseShareCB.SelectedItem,
                    Values = new ChartValues<double> { 14, 6, 5, 2 ,4 }
                },

            };

            Labels = new[] { "Jan", "Feb", "Mar", "Apr", "May" };
            YFormatter = value => value.ToString("C");

            //modifying the series collection will animate and update the chart


            //modifying any series values will also animate and update the chart
            SeriesCollection[0].Values.Add(5d);

            DataContext = this;


        }
    }
    
}

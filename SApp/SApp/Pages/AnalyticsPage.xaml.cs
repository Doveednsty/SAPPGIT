using LiveCharts;
using LiveCharts.Wpf;
using SApp.Data;
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
    /// Логика взаимодействия для AnalyticsPage.xaml
    /// </summary>
    public partial class AnalyticsPage : Page
    {
        public AnalyticsPage()
        {
            InitializeComponent();
            
        }


        public SeriesCollection SeriesCollection { get; set; }
        public string[] Labels { get; set; }
        public Func<double, string> YFormatter { get; set; }


        private void Calc_btn_Click(object sender, RoutedEventArgs e)
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

        

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            List<string> lines = File.ReadAllLines("E:/repos2/SApp/SApp/Data/Secidforcb.txt").ToList();
            ChooseShareCB.ItemsSource = lines;
        }

        private void AllTimebtn_MouseEnter(object sender, MouseEventArgs e)
        {
            var bc = new BrushConverter();
            var fc = new BrushConverter();
            AllTimebtn.Background = (Brush)bc.ConvertFrom("#5ab9ea");
            AllTimebtn.Foreground = (Brush)bc.ConvertFrom("#f0f0f0");
        }

        private void AllTimebtn_MouseLeave(object sender, MouseEventArgs e)
        {
            var bc = new BrushConverter();
            var fc = new BrushConverter();
            AllTimebtn.Background = Brushes.Transparent;
            AllTimebtn.Foreground = (Brush)bc.ConvertFrom("#252525");
        }

        private void Yearbtn_MouseEnter(object sender, MouseEventArgs e)
        {
            var bc = new BrushConverter();
            var fc = new BrushConverter();
            Yearbtn.Foreground = (Brush)bc.ConvertFrom("#f0f0f0");
            Yearbtn.Background = (Brush)bc.ConvertFrom("#5ab9ea");
            
        }

        private void Yearbtn_MouseLeave(object sender, MouseEventArgs e)
        {
            var bc = new BrushConverter();
            var fc = new BrushConverter();
            Yearbtn.Background = Brushes.Transparent;
            Yearbtn.Foreground = (Brush)bc.ConvertFrom("#252525");
        }

        private void SixMonthbtn_MouseEnter(object sender, MouseEventArgs e)
        {
            var bc = new BrushConverter();
            var fc = new BrushConverter();
            SixMonthbtn.Foreground = (Brush)bc.ConvertFrom("#f0f0f0");
            SixMonthbtn.Background = (Brush)bc.ConvertFrom("#5ab9ea");
        }

        private void SixMonthbtn_MouseLeave(object sender, MouseEventArgs e)
        {
            var bc = new BrushConverter();
            var fc = new BrushConverter();
            SixMonthbtn.Background = Brushes.Transparent;
            SixMonthbtn.Foreground = (Brush)bc.ConvertFrom("#252525");
        }

        private void ThreeMonthbtn_MouseEnter(object sender, MouseEventArgs e)
        {
            var bc = new BrushConverter();
            var fc = new BrushConverter();
            ThreeMonthbtn.Foreground = (Brush)bc.ConvertFrom("#f0f0f0");
            ThreeMonthbtn.Background = (Brush)bc.ConvertFrom("#5ab9ea");
        }

        private void ThreeMonthbtn_MouseLeave(object sender, MouseEventArgs e)
        {
            var bc = new BrushConverter();
            var fc = new BrushConverter();
            ThreeMonthbtn.Background = Brushes.Transparent;
            ThreeMonthbtn.Foreground = (Brush)bc.ConvertFrom("#252525");
        }

        private void Monthbtn_MouseLeave(object sender, MouseEventArgs e)
        {
            var bc = new BrushConverter();
            var fc = new BrushConverter();
            Monthbtn.Background = Brushes.Transparent;
            Monthbtn.Foreground = (Brush)bc.ConvertFrom("#252525");
        }

        private void Monthbtn_MouseEnter(object sender, MouseEventArgs e)
        {
            var bc = new BrushConverter();
            var fc = new BrushConverter();
            Monthbtn.Foreground = (Brush)bc.ConvertFrom("#f0f0f0");
            Monthbtn.Background = (Brush)bc.ConvertFrom("#5ab9ea");
        }

        private void Weekbtn_MouseEnter(object sender, MouseEventArgs e)
        {
            var bc = new BrushConverter();
            var fc = new BrushConverter();
            Weekbtn.Foreground = (Brush)bc.ConvertFrom("#f0f0f0");
            Weekbtn.Background = (Brush)bc.ConvertFrom("#5ab9ea");
        }

        private void Weekbtn_MouseLeave(object sender, MouseEventArgs e)
        {
            var bc = new BrushConverter();
            var fc = new BrushConverter();
            Weekbtn.Background = Brushes.Transparent;
            Weekbtn.Foreground = (Brush)bc.ConvertFrom("#252525");
        }

        private void Daybtn_MouseEnter(object sender, MouseEventArgs e)
        {
            var bc = new BrushConverter();
            var fc = new BrushConverter();
            Daybtn.Foreground = (Brush)bc.ConvertFrom("#f0f0f0");
            Daybtn.Background = (Brush)bc.ConvertFrom("#5ab9ea");
        }

        private void Daybtn_MouseLeave(object sender, MouseEventArgs e)
        {
            var bc = new BrushConverter();
            var fc = new BrushConverter();
            Daybtn.Background = Brushes.Transparent;
            Daybtn.Foreground = (Brush)bc.ConvertFrom("#252525");
        }

        private void AtNowbtn_MouseLeave(object sender, MouseEventArgs e)
        {
            var bc = new BrushConverter();
            var fc = new BrushConverter();
            AtNowbtn.Background = Brushes.Transparent;
            AtNowbtn.Foreground = (Brush)bc.ConvertFrom("#252525");
        }

        private void AtNowbtn_MouseEnter(object sender, MouseEventArgs e)
        {
            var bc = new BrushConverter();
            var fc = new BrushConverter();
            AtNowbtn.Foreground = (Brush)bc.ConvertFrom("#f0f0f0");
            AtNowbtn.Background = (Brush)bc.ConvertFrom("#5ab9ea");
        }
    }

}

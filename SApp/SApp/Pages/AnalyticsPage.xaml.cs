using LiveCharts;
using LiveCharts.Wpf;
using SApp.Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
        public List<string> Labels { get; set; }
        public Func<double, string> YFormatter { get; set; }


        private void Calc_btn_Click(object sender, RoutedEventArgs e) 
        {
            
        }

        

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            List<string> lines = File.ReadAllLines(Directory.GetCurrentDirectory() + "/Data/Secidforcb.txt").ToList();
            ChooseShareCB.ItemsSource = lines;
        }

        private void AllTimebtn_MouseEnter(object sender, MouseEventArgs e)
        {
            var bc = new BrushConverter();
            AllTimebtn.Background = (Brush)bc.ConvertFrom("#5ab9ea");
            AllTimebtn.Foreground = (Brush)bc.ConvertFrom("#f0f0f0");
        }

        private void AllTimebtn_MouseLeave(object sender, MouseEventArgs e)
        {
            var bc = new BrushConverter();
            AllTimebtn.Background = Brushes.Transparent;
            AllTimebtn.Foreground = (Brush)bc.ConvertFrom("#252525");
        }

        private void Yearbtn_MouseEnter(object sender, MouseEventArgs e)
        {
            var bc = new BrushConverter();
            Yearbtn.Foreground = (Brush)bc.ConvertFrom("#f0f0f0");
            Yearbtn.Background = (Brush)bc.ConvertFrom("#5ab9ea");
            
        }

        private void Yearbtn_MouseLeave(object sender, MouseEventArgs e)
        {
            var bc = new BrushConverter();
            Yearbtn.Background = Brushes.Transparent;
            Yearbtn.Foreground = (Brush)bc.ConvertFrom("#252525");
        }

        private void SixMonthbtn_MouseEnter(object sender, MouseEventArgs e)
        {
            var bc = new BrushConverter();
            SixMonthbtn.Foreground = (Brush)bc.ConvertFrom("#f0f0f0");
            SixMonthbtn.Background = (Brush)bc.ConvertFrom("#5ab9ea");
        }

        private void SixMonthbtn_MouseLeave(object sender, MouseEventArgs e)
        {
            var bc = new BrushConverter();
            SixMonthbtn.Background = Brushes.Transparent;
            SixMonthbtn.Foreground = (Brush)bc.ConvertFrom("#252525");
        }

        private void ThreeMonthbtn_MouseEnter(object sender, MouseEventArgs e)
        {
            var bc = new BrushConverter();
            ThreeMonthbtn.Foreground = (Brush)bc.ConvertFrom("#f0f0f0");
            ThreeMonthbtn.Background = (Brush)bc.ConvertFrom("#5ab9ea");
        }

        private void ThreeMonthbtn_MouseLeave(object sender, MouseEventArgs e)
        {
            var bc = new BrushConverter();
            ThreeMonthbtn.Background = Brushes.Transparent;
            ThreeMonthbtn.Foreground = (Brush)bc.ConvertFrom("#252525");
        }

        private void Monthbtn_MouseLeave(object sender, MouseEventArgs e)
        {
            var bc = new BrushConverter();
            Monthbtn.Background = Brushes.Transparent;
            Monthbtn.Foreground = (Brush)bc.ConvertFrom("#252525");
        }

        private void Monthbtn_MouseEnter(object sender, MouseEventArgs e)
        {
            var bc = new BrushConverter();
            Monthbtn.Foreground = (Brush)bc.ConvertFrom("#f0f0f0");
            Monthbtn.Background = (Brush)bc.ConvertFrom("#5ab9ea");
        }

        private void Weekbtn_MouseEnter(object sender, MouseEventArgs e)
        {
            var bc = new BrushConverter();
            Weekbtn.Foreground = (Brush)bc.ConvertFrom("#f0f0f0");
            Weekbtn.Background = (Brush)bc.ConvertFrom("#5ab9ea");
        }

        private void Weekbtn_MouseLeave(object sender, MouseEventArgs e)
        {
            var bc = new BrushConverter();
            Weekbtn.Background = Brushes.Transparent;
            Weekbtn.Foreground = (Brush)bc.ConvertFrom("#252525");
        }

        private void Daybtn_MouseEnter(object sender, MouseEventArgs e)
        {
            var bc = new BrushConverter();
            Daybtn.Foreground = (Brush)bc.ConvertFrom("#f0f0f0");
            Daybtn.Background = (Brush)bc.ConvertFrom("#5ab9ea");
        }

        private void Daybtn_MouseLeave(object sender, MouseEventArgs e)
        {
            var bc = new BrushConverter();
            Daybtn.Background = Brushes.Transparent;
            Daybtn.Foreground = (Brush)bc.ConvertFrom("#252525");
        }

        private void AtNowbtn_MouseLeave(object sender, MouseEventArgs e)
        {
            var bc = new BrushConverter();
            AtNowbtn.Background = Brushes.Transparent;
            AtNowbtn.Foreground = (Brush)bc.ConvertFrom("#252525");
        }

        private void AtNowbtn_MouseEnter(object sender, MouseEventArgs e)
        {
            var bc = new BrushConverter();
            AtNowbtn.Foreground = (Brush)bc.ConvertFrom("#f0f0f0");
            AtNowbtn.Background = (Brush)bc.ConvertFrom("#5ab9ea");
        }





        public string YearStart(string filepath)
        {
            //var file = Directory.GetCurrentDirectory() + "/Data/ACKO1.csv";
            var lines = System.IO.File.ReadAllLines(filepath); // @"E:\SAPPGIT\SApp\SApp\Data\ACKO1.csv"
            var line = lines[0];
            string element = line[10] + "" + line[11] + "" + line[12] + "" + line[13] + "";

            char[] symbol = line.ToCharArray();
            int j = 0;
            string s = " ";
            for (int i = 0; i < symbol.Length; i++)
            {
                if (symbol[i].CompareTo(',') == 0)
                {
                    j++;
                    if (j == 2)
                    {
                        s = symbol[i + 1] + "" + symbol[i + 2] + "" + symbol[i + 3] + "" + symbol[i + 4];
                        break;
                    }
                }
            }
            //string element = line[10] + "" + line[11] + "" + line[12] + "" + line[13] + "";
            //MessageBox.Show(element);
            return s;
        }

        public string YearEnd(string filepath)
        {
            //var file = Directory.GetCurrentDirectory() + "/Data/ACKO1.csv";
            var lines = System.IO.File.ReadAllLines(filepath); // @"E:\SAPPGIT\SApp\SApp\Data\ACKO1.csv"
            var line = lines.Last();
            char[] symbol = line.ToCharArray();
            int j = 0;
            string s = " ";
            for (int i = 0; i < symbol.Length; i++)
            {
                if (symbol[i].CompareTo(',') == 0)
                {
                    j++;
                    if (j == 2)
                    {
                        s = symbol[i + 1] + "" + symbol[i + 2] + "" + symbol[i + 3] + "" + symbol[i + 4];
                        break;
                    }
                }
            }
            //string element = line[10] + "" + line[11] + "" + line[12] + "" + line[13] + "";
            //MessageBox.Show(element);
            return s;
        }


        private void AllTimebtn_Click(object sender, RoutedEventArgs e)
        {

            SeriesCollection = new SeriesCollection
            {
                new LineSeries
                {
                    Title = (string)ChooseShareCB.SelectedItem,
                    Values = new ChartValues<double>{ 2, 5, 7, 4, 3, 5 }// вот тут должны быть значения акций --> ?LINQ?
                    
                },

            };

            int yearStart = Convert.ToInt32(YearStart("E:/SAPPGIT/SApp/SApp/Data/ACKO1.csv"));
            int yearEnd = Convert.ToInt32(YearEnd("E:/SAPPGIT/SApp/SApp/Data/ACKO36.csv"));




            //Labels = new[] { yearStart.ToString(), "Feb", "Mar", "Apr", yearEnd.ToString() };
            Labels = new List<string>();
            int j = yearStart;
            for (int i = yearStart - 1; i < yearEnd; i++)
            {
                if (i < yearEnd)
                {
                    Labels.Add((i + 1).ToString());
                }
            }

            YFormatter = value => value.ToString("C");

            //modifying the series collection will animate and update the chart


            //modifying any series values will also animate and update the chart
            //SeriesCollection[0].Values.Add(1001d);

            DataContext = this;
        }
    }

}

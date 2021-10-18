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
using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Helpers;
using System.Globalization;

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
            //using (FileStream fs = new FileStream("user.json", FileMode.OpenOrCreate))
            //{
            //    Person tom = new Person() { Name = "Tom", Age = 35 };
            //    await JsonSerializer.SerializeAsync<Person>(fs, tom);
            //    Console.WriteLine("Data has been saved to file");
            //}
            //graphic.Labels = 
            //SeriesCollection = new SeriesCollection
            //        {
            //            new LineSeries
            //            {
            //                Values = new ChartValues<double>{ 1, 2, 3, 4, 6, 999 }// вот тут должны быть значения акций --> ?LINQ?  ось Y
                            
            //            },
            //        };
            //Labels = new List<string> { "2", "34", "3", "6" }; // ось X
            //YFormatter = value => value.ToString("C");
            //DataContext = this;
        }

        public SeriesCollection SeriesCollection { get; set; }
        public string[] Labels { get; set; }
        public Func<double, string> YFormatter { get; set; }

        public List<double> OsY = new List<double> { };
        public List<DateTime> OsX = new List<DateTime> { };



        private void Trackingbtn_Click(object sender, RoutedEventArgs e)
        {
            ////try
            ////{
            //if (ChooseShareCB.Text == "" || InputPriceTB.Text == "" || Convert.ToDouble(InputPriceTB.Text) < 0)
            //{
            //    MessageBox.Show("Заполните верные данные в данном окне", "Данные не найдены", MessageBoxButton.OK, MessageBoxImage.Error);
            //}
            //else
            //{

            

            OsY.Add(double.Parse(InputPriceTB.Text));
            OsX.Add(DateTime.Now);



            ModelTracking modelTracking = new ModelTracking(ChooseShareCB.Text, InputPriceTB.Text);
            CurrentDateTB.Text = DateTime.Now.ToString();
            CurrentPriceTB.Text = InputPriceTB.Text; 
            CurrentIdTB.Text = ChooseShareCB.Text;
                    
            CreateDateTimeTB();
            CreateIdTB(modelTracking.SECID());
            CreatePriceTB(modelTracking.Price());

            IFormatProvider formatter = new NumberFormatInfo { NumberDecimalSeparator = "." };
            OsY.Add(double.Parse(modelTracking.Price(), formatter));

            var osyArr = OsY.ToArray();
            //var osxArr = OsX.ToArray();
            SeriesCollection = new SeriesCollection
            {
                new LineSeries
                {
                    Title = (string)ChooseShareCB.Text,
                    Values = osyArr.AsChartValues(),
                },
                
            };
            var b = new[] { (OsX.ToArray()).ToString() };
            Labels = b;
            YFormatter = value => value.ToString("C");


           

            DataContext = this;

              

                    
            //}
            //}
            //catch (Exception)
            //{
            //    MessageBox.Show("Проверьте правильность введенных данных", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            //}
            

            
        }

        

        public void CreateDateTimeTB()
        {
            System.Windows.Controls.TextBlock textBlock = new TextBlock { Text = DateTime.Now.ToString() };
            DateFamilySP.Children.Add(textBlock);
        }

        public void CreatePriceTB(string m)
        {
            TextBlock textBlock = new TextBlock { Text = m };
            PriceFamilySP.Children.Add(textBlock);
        }

        public void CreateIdTB(string m)
        {
            System.Windows.Controls.TextBlock textBlock = new TextBlock { Text = m };
            IDFamilySP.Children.Add(textBlock);
        }

        private void SaveDataTracking_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Данные сохранены в формате JSON", "Сохранение", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
    
}

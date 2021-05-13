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

        
        

        private void Trackingbtn_Click(object sender, RoutedEventArgs e)
        {



            if (ChooseShareCB.Text == "" || InputPriceTB.Text == "" || Convert.ToDouble(InputPriceTB.Text) < 0)
            {
                MessageBox.Show("Заполните верные данные в данном окне", "Данные не найдены", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                Graphic graphic = new Graphic();
                graphic.ChosenShare = ChooseShareCB.Text;
                graphic.BuildChart();

                ModelTracking modelTracking = new ModelTracking(ChooseShareCB.Text, InputPriceTB.Text);
                CurrentDateTB.Text = DateTime.Now.ToString();
                CurrentPriceTB.Text = InputPriceTB.Text;
                CreateDateTimeTB();
                CreatePriceTB(modelTracking.Price());
            }
            //using (FileStream fs = new FileStream("user.json", FileMode.OpenOrCreate))
            //{
            //    Person tom = new Person() { Name = "Tom", Age = 35 };
            //    await JsonSerializer.SerializeAsync<Person>(fs, tom);
            //    Console.WriteLine("Data has been saved to file");
            //}
            //graphic.Labels = 







            



            
        }

        public void CreateDateTimeTB()
        {
            System.Windows.Controls.TextBlock textBlock = new TextBlock();
            textBlock.Text = DateTime.Now.ToString();
            DateFamilySP.Children.Add(textBlock);
        }

        public void CreatePriceTB(string m)
        {
            System.Windows.Controls.TextBlock textBlock = new TextBlock();
            textBlock.Text = m;
            PriceFamilySP.Children.Add(textBlock);
        }
    }
    
}

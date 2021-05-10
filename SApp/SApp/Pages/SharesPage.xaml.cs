using SApp.Data;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
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
    /// Логика взаимодействия для SharesPage.xaml
    /// </summary>
    public partial class SharesPage : Page
    {
        public SharesPage()
        {
            InitializeComponent();
            DataShares dataShares = new DataShares();
            DataContext = dataShares.ReadFile("Table.csv");
        }


        async void RefreshingShares() // !!!Parallel Invoke should be!!!!
        {
            var time = 900 * 1000; //15 minute
            await Task.Run(async () =>
            {
                while (true) 
                {
                    Thread.CurrentThread.IsBackground = true;
                    Process.Start("getshares");
                    await Task.Delay(time);
                    foreach(Process process in Process.GetProcessesByName("getshares"))
                    {
                        process.Kill();
                    }
                }
                
                
            });
        }



        private void Refresh_btn_Click(object sender, RoutedEventArgs e)
        {
            foreach (Process process in Process.GetProcessesByName("getshares"))
            {
                process.Kill();
            }
            Process.Start("getshares");
            Thread.Sleep(1000);
            MessageBox.Show("Данные успешно обновлены", "Обновление данных", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            RefreshingShares();
        }

        
    }
}

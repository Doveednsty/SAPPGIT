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
            DataContext = dataShares.ReadFile(@"E:\repos2\SApp\SApp\Scripts\Table.csv");
        }


        public bool isHaveProcess(string pName)
        {
            Process[] pList = Process.GetProcessesByName("notepad");
            foreach (Process myProcess in pList)
            {
                if (myProcess.ProcessName == pName)
                    return true;
            }
            return false;
        }


        private async void Refresh_btn_Click(object sender, RoutedEventArgs e)
        {
            await Task.Run(async () =>
            {
                while (true)
                {

                Process.Start("notepad");
                await Task.Delay(1000);
                }
            });
            
        }

        private async void Page_Loaded(object sender, RoutedEventArgs e)
        {
            
            await Task.Run(() =>
            {
                //if (isHaveProcess("notepad.exe") == false)
                //{
                //    Process.Start("notepad.exe");
                //}
                //proc.Kill("notepad.exe");
                //proc.Start("notepad.exe");

                
                //foreach (Process proc in Process.GetProcessesByName("notepad"))
                //{
                //    proc.Kill();
                //}
               


            }
            );
        }
           
    }
}

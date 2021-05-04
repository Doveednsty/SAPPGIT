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

        private void Refresh_btn_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            
        }
           
    }
}

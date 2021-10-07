using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using SApp.Data;
using SApp.Pages;

namespace SApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            foreach(Process proc in Process.GetProcessesByName("getshares.exe"))
            {
                proc.Kill();
            }
            
        }

        private void AnalysPage_btn_Click(object sender, RoutedEventArgs e)
        {
            AnalyticsPage analyticsPage = new AnalyticsPage();
            Basis.Content = analyticsPage;
        }

        private void SharesPage_btn_Click(object sender, RoutedEventArgs e)
        {
            SharesPage sharesPage = new SharesPage();
            Basis.Content = sharesPage;
        }

        private void NewsPage_btn_Click(object sender, RoutedEventArgs e)
        {
            NewsPage newsPage = new NewsPage();
            Basis.Content = newsPage;
        }

        private void Basis_Loaded(object sender, RoutedEventArgs e)
        {
            Basis.Content = new SharesPage();
        }

        private void TrackingPage_btn_Click(object sender, RoutedEventArgs e)
        {
            Basis.Content = new TrackingPage();
        }

        private void HoverForBtns_Click_MouseEnter(object sender, MouseEventArgs e)
        {
            var bc = new BrushConverter();
            
            string name = (sender as Button).Name;
            if (name == "SharesPage_btn") SharesPage_btn.Background = (Brush)bc.ConvertFrom("#f0f0f0");
            else if (name == "AnalysePage_btn") AnalysePage_btn.Background = (Brush)bc.ConvertFrom("#f0f0f0");
            else if (name == "TrackingPage_btn") TrackingPage_btn.Background = (Brush)bc.ConvertFrom("#f0f0f0");
            else if (name == "NewsPage_btn") NewsPage_btn.Background = (Brush)bc.ConvertFrom("#f0f0f0");
        }
        
        private void HoverDownForBtns_Click_MouseLeave(object sender, MouseEventArgs e)
        {
            var bc = new BrushConverter();
            string name = (sender as Button).Name;
            if (name == "SharesPage_btn") SharesPage_btn.Background = (Brush)bc.ConvertFrom("#f0f0f0");
            else if (name == "AnalysePage_btn") AnalysePage_btn.Background = (Brush)bc.ConvertFrom("#f0f0f0");
            else if (name == "TrackingPage_btn") TrackingPage_btn.Background = (Brush)bc.ConvertFrom("#f0f0f0");
            else if (name == "NewsPage_btn") NewsPage_btn.Background = (Brush)bc.ConvertFrom("#f0f0f0");
        } 
    }
}

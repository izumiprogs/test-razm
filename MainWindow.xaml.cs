using System;
using System.Collections.Generic;
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
using static System.Net.WebRequestMethods;

namespace test
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            MyFrame.Source = new Uri("MainWindow.xaml" UriKind.Relative);
            InitializeComponent();
        }

        void Page1_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Content = new Page1();
           

        }

        private void Page2_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Content = new Page2();
        }

        private void Page3_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Content = new Page3();
        }

        private void Page4_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Content = new Page4();
        }

        private void Page5_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Content = new Page5();
        }

        private void Page6_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}

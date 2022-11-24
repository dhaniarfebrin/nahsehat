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

namespace NahSehat
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Main.Content = new Home();
        }

        private void Home_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new Home();
        }

        private void News_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new News();
        }

        private void Dieseas_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new Dieseas();   
        }

        private void Covid_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new Covid();
        }
    }
}

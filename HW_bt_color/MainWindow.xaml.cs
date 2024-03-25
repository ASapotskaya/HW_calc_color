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

namespace HW_bt_color
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void bt_navy_Click(object sender, RoutedEventArgs e)
        {
            Bt_color.Background = new SolidColorBrush(Colors.Navy);
        }

        private void bt_blue_Click(object sender, RoutedEventArgs e)
        {
            Bt_color.Background = new SolidColorBrush(Colors.Blue);
        }

        private void bt_aqua_Click(object sender, RoutedEventArgs e)
        {
            Bt_color.Background = new SolidColorBrush(Colors.Aqua);
        }

        private void bt_teal_Click(object sender, RoutedEventArgs e)
        {
            Bt_color.Background = new SolidColorBrush(Colors.Teal);
        }

        private void bt_olive_Click(object sender, RoutedEventArgs e)
        {
            Bt_color.Background = new SolidColorBrush(Colors.Olive);
        }

        private void bt_green_Click(object sender, RoutedEventArgs e)
        {
            Bt_color.Background = new SolidColorBrush(Colors.Green);
        }

        private void bt_lime_Click(object sender, RoutedEventArgs e)
        {
            Bt_color.Background = new SolidColorBrush(Colors.Lime);
        }

        private void bt_yellow_Click(object sender, RoutedEventArgs e)
        {
            Bt_color.Background = new SolidColorBrush(Colors.Yellow);
        }

        private void bt_orange_Click(object sender, RoutedEventArgs e)
        {
            Bt_color.Background = new SolidColorBrush(Colors.Orange);
        }

        private void bt_red_Click(object sender, RoutedEventArgs e)
        {
            Bt_color.Background = new SolidColorBrush(Colors.Red);
        }

        private void bt_maroon_Click(object sender, RoutedEventArgs e)
        {
            Bt_color.Background = new SolidColorBrush(Colors.Maroon);
        }

        private void bt_fuchsia_Click(object sender, RoutedEventArgs e)
        {
            Bt_color.Background = new SolidColorBrush(Colors.Fuchsia);
        }

        private void bt_purple_Click(object sender, RoutedEventArgs e)
        {
            Bt_color.Background = new SolidColorBrush(Colors.Purple);
        }

        private void bt_black_Click(object sender, RoutedEventArgs e)
        {
            Bt_color.Background = new SolidColorBrush(Colors.Black);
        }

        private void bt_silver_Click(object sender, RoutedEventArgs e)
        {
            Bt_color.Background = new SolidColorBrush(Colors.Silver);
        }

        private void bt_gray_Click(object sender, RoutedEventArgs e)
        {
            Bt_color.Background = new SolidColorBrush(Colors.Gray);
        }

        private void bt_white_Click(object sender, RoutedEventArgs e)
        {
            Bt_color.Background = new SolidColorBrush(Colors.White);
        }
    }
}

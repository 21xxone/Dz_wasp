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

namespace WpfApp1
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

        private void Bt_one_Click(object sender, RoutedEventArgs e)
        {
            text_box.Text += "1";
        }

        private void bt_two_Click(object sender, RoutedEventArgs e)
        {
            text_box.Text += "2";
        }

        private void bt_three_Click(object sender, RoutedEventArgs e)
        {
            text_box.Text += "3";
        }

        private void bt_four_Click(object sender, RoutedEventArgs e)
        {
            text_box.Text += "4";
        }

        private void button_five_Click(object sender, RoutedEventArgs e)
        {
            text_box.Text += "5";
        }

        private void bt_six_Click(object sender, RoutedEventArgs e)
        {
            text_box.Text += "6";
        }

        private void bt_seven_Click(object sender, RoutedEventArgs e)
        {
            text_box.Text += "7";
        }

        private void bt_eight_Click(object sender, RoutedEventArgs e)
        {
            text_box.Text += "8";
        }

        private void bt_nine_Click(object sender, RoutedEventArgs e)
        {
            text_box.Text += "9";
        }

        private void Bt_delete_Click(object sender, RoutedEventArgs e)
        {
            text_box.Text = "";
        }

        private void Bt_check_Click(object sender, RoutedEventArgs e)
        {
            if (text_box.Text == "33333")
            {
                Text_box_nope.Text = "Ura😟";
                Bt_one.IsEnabled = false;
                bt_two.IsEnabled = false;
                bt_three.IsEnabled = false;
                bt_four.IsEnabled = false;
                button_five.IsEnabled = false;
                bt_six.IsEnabled = false;
                bt_seven.IsEnabled = false;
                bt_eight.IsEnabled = false;
                bt_nine.IsEnabled = false;
                Bt_zero.IsEnabled = false;
                Bt_check.IsEnabled = false;
                Bt_delete.IsEnabled = false;
                Bt_one.IsEnabled = false;
                text_box.IsEnabled = false;
                Text_box_nope.IsEnabled = false;
            }
            else
            {
                Text_box_nope.Text = "nope";
                text_box.Text = "";
            }
        }

        private void Bt_zero_Click(object sender, RoutedEventArgs e)
        {
            text_box.Text += "0";
        }
    }
}

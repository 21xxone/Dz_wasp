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
using System.Windows.Threading;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer timer = new DispatcherTimer();
        Random random = new Random();
        List<Button> btns;
        public MainWindow()
        {
            InitializeComponent();
            timer.Interval = TimeSpan.FromSeconds(7);
            timer.Tick += RandomButtons;
            timer.Start();
        }
        private void RandomButtons(object sender, EventArgs e)
        {
            btns = new List<Button>() { btn0, btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9 };
            List<int> number = new List<int>() { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 };
            foreach (int i in number)
            {
                Button btn = btns[random.Next(0, i)];
                btn.Background = new SolidColorBrush(Color.FromArgb((byte)random.Next(20, 220), (byte)random.Next(20, 220),
                    (byte)random.Next(20, 220), (byte)random.Next(20, 220)));
                btn.Content = i;
                btns.Remove(btn);
            }
            timer.Interval = TimeSpan.FromSeconds(7);
        }
        private void btn_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            RandomButtons(btn, null);
        }
        private void btndelete_Click(object sender, RoutedEventArgs e)
        {
            text_box.Text = "";
            btns = new List<Button>() { btn0, btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9 };
            foreach (Button i in btns)
            {
                i.Content = "";
            }
        }


    }
}

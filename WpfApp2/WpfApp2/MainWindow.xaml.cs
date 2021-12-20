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

namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer timer = new DispatcherTimer();
        public MainWindow()
        {
            InitializeComponent();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += Button_add;
            timer.Start();
        }
        private void Button_add(object sender, EventArgs e)
        {
            Button button = new Button();
            Random color = new Random();
            button.Content = "Давай, ломай ломай";
            button.Height = 50;
            button.Width = 100;
            button.MouseEnter += Mouse;
            button.Background = new SolidColorBrush(Color.FromArgb((byte)color.Next(0, 256), (byte)color.Next(0, 256), (byte)color.Next(0, 256), (byte)color.Next(0, 256)));
            Grid.Children.Add(button);
        }
        private void button_gps(Button button)
        {
            Random loc = new Random();
            int locX;
            int locY;
            locX = loc.Next(0, Convert.ToInt32(Width) - 100);
            locY = loc.Next(0, Convert.ToInt32(Height) - 50);
            Thickness margin = new Thickness(locX, locY, 0, 0);
            button.Margin = margin;
        }
        private void Mouse(object sender, MouseEventArgs e)
        {
            button_gps(sender as Button);
        }
    }
}

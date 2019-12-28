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
using System.Diagnostics;
using System.Globalization;

namespace Task1
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

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Debug.WriteLine($"MouseDown: source {e.Source} sender {sender}");
        }

        private void _MouseEnter(object sender, MouseEventArgs e)
        {
            Debug.WriteLine($"MouseEnter: source {e.Source} sender {sender}");
        }

        private void _Click(object sender, RoutedEventArgs e)
        {
            if (typeof(CheckBox)==e.Source.GetType())
            {

            }
            else
            for (int i = 1; i < 4; i++)
            {
                    var button = new Button() { Content = $"Button{i}"};
                    button.Click += Button_Click;
                    this.MyStack.Children.Add(button);

            }
            //Debug.WriteLine($"Click: source {e.Source} sender {sender}");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            e.Handled = true;
            (sender as Button).Background = Brushes.Red;
        }

        private void Window_Scroll(object sender, System.Windows.Controls.Primitives.ScrollEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }

    public class BrushColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if ((bool)value)
            {
                {
                    return new SolidColorBrush(Colors.Yellow);
                }
            }
            return new SolidColorBrush(Colors.Transparent);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}

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

namespace Task2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string prevContent1 = "-->Next other page and window";
        string prevContent2 = "<--Prev               other page and window";
        string tempContent1;
        string tempContent2;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            tempContent1 = button1.Content.ToString();
            tempContent2 = button2.Content.ToString();
            button1.Content = prevContent1;
            button2.Content = prevContent2;
            prevContent1 = tempContent1;
            prevContent2 = tempContent2;
        }

        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            this.CheckBox_Checked(sender, e);
        }
    }
}

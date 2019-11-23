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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private int Counter { get; set; } = 0;

        private void ButtonAdd_Click(object sender, RoutedEventArgs e)
        {
            this.ListOfItems.Items.Add($"NewItem{this.Counter}");

            if (this.Counter == 1)
            {
                this.ListOfItems.Items.Remove($"NewItem{this.Counter - 1}");

                this.Counter++;
            }
        }

        private void ButtonDelete_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonClear_Click(object sender, RoutedEventArgs e)
        {
            this.ListOfItems.Items.Clear();
        }
    }
}

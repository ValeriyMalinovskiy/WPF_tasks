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

        private void OnAddButtonClick(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(this.EnteredText.Text))
            {
                this.ListOfItems.Items.Add(this.EnteredText.Text);
            }

        }

        private void OnDeleteButtonClick(object sender, RoutedEventArgs e)
        {
            this.ListOfItems.Items.Remove(this.ListOfItems.SelectedItem);
        }

        private void OnClearButtonClick(object sender, RoutedEventArgs e)
        {
            this.ListOfItems.Items.Clear();
        }
    }
}

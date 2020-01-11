using Author_s_book_list.Class;
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
using System.Windows.Shapes;

namespace Author_s_book_list.Views
{
    /// <summary>
    /// Interaction logic for NewAuthorWindow.xaml
    /// </summary>
    public partial class NewAuthorWindow : Window
    {
        public NewAuthorWindow(Author author)
        {
            InitializeComponent();
            this.DataContext = author;
        }

        private void OkCommandExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            this.DialogResult = true;
        }

        private void OkCommandCanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }
    }
}

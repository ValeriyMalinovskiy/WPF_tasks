using Author_s_book_list.Class;
using System;
using System.Windows;
using System.Windows.Input;

namespace Author_s_book_list.Views
{
    /// <summary>
    /// Interaction logic for NewBookWindow.xaml
    /// </summary>
    public partial class NewBookWindow : Window
    {
        public NewBookWindow(Book book)
        {
            InitializeComponent();
            this.DataContext = book;
        }

        private void OkCommandExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            this.DialogResult = true;
        }

        private void OkCommandCanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(this.Title.Text) || !Decimal.TryParse(this.BookValue.Text, out decimal result))
            {
            }
            else
            {
                e.CanExecute = true;
            }
        }

        private void CancelCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            this.DialogResult = false;
        }

        private void CancelCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }
    }
}

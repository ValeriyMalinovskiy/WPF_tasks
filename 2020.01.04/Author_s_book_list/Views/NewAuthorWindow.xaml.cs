using Author_s_book_list.Class;
using System.Windows;
using System.Windows.Input;

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
            if (string.IsNullOrEmpty(this.PlaceOfBirth.Text) || string.IsNullOrEmpty(this.FirstName.Text) || string.IsNullOrEmpty(this.LastName.Text))
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

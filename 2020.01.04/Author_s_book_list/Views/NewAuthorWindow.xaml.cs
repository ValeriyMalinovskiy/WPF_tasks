using Author_s_book_list.Class;
using System.Windows;
using System.Windows.Controls;
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

        private void UniqueCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            switch ((e.Source as Button).Name)
            {
                case "OkButton":
                    {
                        this.DialogResult = true;
                    }
                    break;

                case "CancelButton":
                    {
                        this.DialogResult = false;
                    }
                    break;
            }
        }

        private void UniqueCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            switch ((e.Source as Button).Name)
            {
                case "OkButton":
                    {
                        if (string.IsNullOrWhiteSpace(this.PlaceOfBirthBox.Text) || string.IsNullOrWhiteSpace(this.FirstNameBox.Text) || string.IsNullOrWhiteSpace(this.LastNameBox.Text) || this.LanguageBox.SelectedItem == null || this.CountryBox.SelectedItem == null)
                        {
                            e.CanExecute = false;
                        }
                        else
                        {
                            e.CanExecute = true;
                        }
                    }
                    break;

                case "CancelButton":
                    {
                        e.CanExecute = true;
                    }
                    break;
            }
        }
    }
}
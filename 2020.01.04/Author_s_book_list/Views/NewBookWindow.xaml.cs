using Author_s_book_list.Class;
using System;
using System.Windows;
using System.Windows.Controls;
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
                        if (string.IsNullOrEmpty(this.Title.Text) || !Decimal.TryParse(this.BookValue.Text, out decimal result))
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

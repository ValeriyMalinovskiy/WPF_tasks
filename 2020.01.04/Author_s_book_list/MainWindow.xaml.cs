using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using Author_s_book_list.Class;
using Author_s_book_list.Views;

namespace Author_s_book_list
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Author> AuthorCollection { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            Author author1 = new Author("Mark", "Twain", new DateTime(1835, 11, 30), Enums.Language.English ,Enums.Country.USA, "Missouri");
            Author author2 = new Author("Mark2", "Twain2", new DateTime(1835, 10, 23), Enums.Language.German ,Enums.Country.Russia, "NewJersey");
            author1.AddBook(new Book("Book1", new DateTime(), 30));
            author2.AddBook(new Book("Book3", new DateTime(), 34));
            AuthorCollection = new ObservableCollection<Author>();
            AuthorCollection.Add(author1);
            AuthorCollection.Add(author2);
            this.AuthorListView.ItemsSource = AuthorCollection;
        }

        private void Bind_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        //public void AddAuthor(Author author)
        //{
        //    this.AuthorCollection.Add(author);
        //}

        private void NewCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            if ((e.Source as Button).Name=="NewBookButton")
            {
                bool newBookSucc = false;
                Book tempBook = new Book();
                NewBookWindow newBookWindow = new NewBookWindow(tempBook);
                newBookSucc = newBookWindow.ShowDialog().Value;
                if (newBookSucc)
                {
                    tempBook.IsNew = false;
                    (this.AuthorListView.SelectedItem as Author).BookCollection.Add(tempBook);
                }
            }
            else
            {
                bool newAuthSucc = false;
                Author tempAuth = new Author();
                NewAuthorWindow newAuthorWindow = new NewAuthorWindow(tempAuth);
                newAuthSucc = newAuthorWindow.ShowDialog().Value;
                if (newAuthSucc)
                {
                    tempAuth.IsNew = false;
                    this.AuthorCollection.Add(tempAuth);
                }
            }
        }

        private void NewCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            if ((e.Source as Button).Name == "NewBookButton" && this.AuthorListView.SelectedItem == null)
            {
            }
            else
            {
                e.CanExecute = true;
            }
        }

        private void DeleteCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            this.AuthorCollection.Remove(this.AuthorListView.SelectedItem as Author);
        }

        private void DeleteCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            if ((e.Source as Button).Name == "DeleteBookButton" && this.BookCollection.SelectedItem == null)
            {
            }
            else if (this.AuthorListView.SelectedItem != null)
            {
                e.CanExecute = true;
            }
        }

        private void ChangeCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            if ((e.Source as Button).Name == "ChangeBookButton")
            {
                NewBookWindow newBookWindow = new NewBookWindow(this.BookCollection.SelectedItem as Book);
                newBookWindow.ShowDialog();
            }
            else
            {
                NewAuthorWindow newAuthorWindow = new NewAuthorWindow(this.AuthorListView.SelectedItem as Author);
                newAuthorWindow.ShowDialog();
            }
        }

        private void ChangeCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            if ((e.Source as Button).Name == "ChangeBookButton" && this.BookCollection.SelectedItem == null)
            {
            }
            else if (this.AuthorListView.SelectedItem != null)
            {
                e.CanExecute = true;
            }
        }
    }
}

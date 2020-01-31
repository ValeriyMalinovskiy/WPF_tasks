using Author_s_book_list.Class;
using Author_s_book_list.Views;
using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

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

            Author author1 = new Author("Mark", "Twain", new DateTime(1835, 11, 30), Enums.Language.English, Enums.Country.USA, "Missouri");
            Author author2 = new Author("Mark2", "Twain2", new DateTime(1835, 10, 23), Enums.Language.German, Enums.Country.Russia, "NewJersey");
            author1.AddBook(new Book("Book1", new DateTime(), 30));
            author2.AddBook(new Book("Book3", new DateTime(), 34));
            AuthorCollection = new ObservableCollection<Author>();
            AuthorCollection.Add(author1);
            AuthorCollection.Add(author2);
            this.AuthorListView.ItemsSource = AuthorCollection;
        }

        private void UniqueCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            switch (e.Source.GetType().Name)
            {
                case "Button":
                    {
                        switch ((e.Source as Button).Name)
                        {
                            case "NewBookButton":
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
                                break;
                            case "ChangeBookButton":
                                {
                                    NewBookWindow newBookWindow = new NewBookWindow(this.BookCollection.SelectedItem as Book);
                                    newBookWindow.ShowDialog();
                                }
                                break;
                            case "DeleteBookButton":
                                {
                                    if (this.BookCollection.SelectedItem != null)
                                    {
                                        (this.AuthorListView.SelectedItem as Author).RemoveBook((this.BookCollection.SelectedItem as Book).Id);
                                    }
                                }
                                break;
                            case "NewAuthorButton":
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
                                break;
                            case "ChangeAuthorButton":
                                {
                                    NewAuthorWindow newAuthorWindow = new NewAuthorWindow(this.AuthorListView.SelectedItem as Author);
                                    newAuthorWindow.ShowDialog();
                                }
                                break;
                            case "DeleteAuthorButton":
                                {
                                    if (this.AuthorListView.SelectedItem != null)
                                    {
                                        this.AuthorCollection.Remove(this.AuthorListView.SelectedItem as Author);
                                    }
                                }
                                break;
                        }
                        break;
                    }
                case "MenuItem":
                    {
                        //if ((e.Source as MenuItem).Name == "NewBookMenuItem" && this.AuthorListView.SelectedItem == null)
                        //{
                        //}
                        //else
                        {
                        }
                        break;
                    }
            }
        }

        private void UniqueCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            switch (e.Source.GetType().Name)
            {
                case "Button":
                    {
                        switch ((e.Source as Button).Name)
                        {
                            case "NewBookButton":
                                {
                                    if (this.AuthorListView.SelectedItem != null)
                                    {
                                        e.CanExecute = true;
                                    }
                                }
                                break;
                            case "ChangeBookButton":
                            case "DeleteBookButton":
                                {
                                    if (this.BookCollection.SelectedItem != null)
                                    {
                                        e.CanExecute = true;
                                    }
                                }
                                break;
                            case "NewAuthorButton":
                                {
                                    e.CanExecute = true;
                                }
                                break;
                            case "ChangeAuthorButton":
                            case "DeleteAuthorButton":
                                {
                                    if (this.AuthorListView.SelectedItem != null)
                                    {
                                        e.CanExecute = true;
                                    }
                                }
                                break;
                        }
                        break;
                    }
                case "MenuItem":
                    {
                        //if ((e.Source as MenuItem).Name == "NewBookMenuItem" && this.AuthorListView.SelectedItem == null)
                        //{
                        //}
                        //else
                        {
                            e.CanExecute = true;
                        }
                        break;
                    }
            }
        }
    }
}

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

            Author author1 = new Author("Mark", "Twain", new DateTime(1835, 11, 30), Enums.Language.English, Enums.Country.USA, "Florida, Missouri");
            Author author2 = new Author("O.", "Henry", new DateTime(1862, 09, 11), Enums.Language.English, Enums.Country.USA, "Greensboro, North Carolina");
            Author author3 = new Author("Isaac", "Asimov", new DateTime(1920, 01, 2), Enums.Language.English, Enums.Country.Russia, "Petrovichi, Smolensk Governorate");
            author1.AddBook(new Book("The Adventures of Tom Sawyer", new DateTime(1876,01,01), 30));
            author2.AddBook(new Book("The Gift of the Magi", new DateTime(1905,12,10), 34));
            author2.AddBook(new Book("The Ransom of Red Chief", new DateTime(1907,07,06), 34));
            AuthorCollection = new ObservableCollection<Author>();
            AuthorCollection.Add(author1);
            AuthorCollection.Add(author2);
            AuthorCollection.Add(author3);
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
                                    (this.AuthorListView.SelectedItem as Author).RemoveBook((this.BookCollection.SelectedItem as Book).Id);
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
                                    this.AuthorCollection.Remove(this.AuthorListView.SelectedItem as Author);
                                }
                                break;
                        }
                        break;
                    }
                case "MenuItem":
                    {
                        switch ((e.Source as MenuItem).Name)
                        {
                            case "NewAuthorMenuItem":
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
                            case "NewBookMenuItem":
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
                            case "DeleteAuthorMenuItem":
                                {
                                    this.AuthorCollection.Remove(this.AuthorListView.SelectedItem as Author);
                                }
                                break;
                            case "DeleteBookMenuItem":
                                {
                                    (this.AuthorListView.SelectedItem as Author).RemoveBook((this.BookCollection.SelectedItem as Book).Id);
                                }
                                break;
                            case "EditAuthorMenuItem":
                                {
                                    NewAuthorWindow newAuthorWindow = new NewAuthorWindow(this.AuthorListView.SelectedItem as Author);
                                    newAuthorWindow.ShowDialog();
                                }
                                break;
                            case "EditBookMenuItem":
                                {
                                    NewBookWindow newBookWindow = new NewBookWindow(this.BookCollection.SelectedItem as Book);
                                    newBookWindow.ShowDialog();
                                }
                                break;
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
                            case "NewAuthorButton":
                                {
                                    e.CanExecute = true;
                                }
                                break;
                            case "NewBookButton":
                            case "ChangeAuthorButton":
                            case "DeleteAuthorButton":
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
                        }
                        break;
                    }
                case "MenuItem":
                    {
                        switch ((e.Source as MenuItem).Name)
                        {
                            case "NewAuthorMenuItem":
                                {
                                    e.CanExecute = true;
                                }
                                break;
                            case "NewBookMenuItem":
                            case "DeleteAuthorMenuItem":
                            case "EditAuthorMenuItem":
                                {
                                    if (this.AuthorListView.SelectedItem != null)
                                    {
                                        e.CanExecute = true;
                                    }
                                }
                                break;
                            case "DeleteBookMenuItem":
                            case "EditBookMenuItem":
                                {
                                    if (this.BookCollection.SelectedItem != null)
                                    {
                                        e.CanExecute = true;
                                    }
                                }
                                break;
                        }
                        break;
                    }
            }
        }
    }
}

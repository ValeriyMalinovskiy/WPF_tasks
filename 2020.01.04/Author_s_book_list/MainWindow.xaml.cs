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

            Author author = new Author("Mark", "Twain", new DateTime(1835, 11, 30), Enums.Language.English ,Enums.Country.USA, Enums.Country.USA, Enums.State.Missouri, Enums.City.Florida);
            author.AddBook(new Book("Book1", new DateTime(), 30));
            AuthorCollection = new ObservableCollection<Author>();
            AuthorCollection.Add(author);
            this.AuthorListView.ItemsSource = AuthorCollection;
        }

        public void AddAuthor(Author author)
        {
            this.AuthorCollection.Add(author);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NewAuthorWindow newAuthorWindow = new NewAuthorWindow();
            newAuthorWindow.Show();
        }
    }

    public static class CustomCommand
    {
        public static RoutedCommand Change { get; set; }

        public static RoutedCommand Ok { get; set; }

        static CustomCommand()
        {
            CustomCommand.Change = new RoutedCommand(nameof(Change), typeof(Window));
            CustomCommand.Ok = new RoutedCommand(nameof(Change), typeof(Window));
        }
    }
}

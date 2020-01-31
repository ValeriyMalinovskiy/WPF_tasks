using Author_s_book_list.Enums;
using System;
using System.Collections.ObjectModel;
using System.Linq;

namespace Author_s_book_list.Class
{
    public class Author : EntityBase
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime DateOfBirth { get; set; }

        public Language Language { get; set; }

        public Country Country { get; set; }

        public string PlaceOfBirth { get; set; }

        public ObservableCollection<Book> BookCollection { get; }

        public Author(string firstName, string lastName, DateTime dateOfBirth, Language language, Country country, string placeOfBirth) : base(false)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.DateOfBirth = dateOfBirth;
            this.Language = language;
            this.Country = country;
            this.PlaceOfBirth = placeOfBirth;
            this.BookCollection = new ObservableCollection<Book>();
        }

        public Author()
        {
            this.DateOfBirth = DateTime.Today;
            this.BookCollection = new ObservableCollection<Book>();
        }

        public void AddBook(Book book)
        {
            this.BookCollection.Add(book);
        }

        public void RemoveBook(int bookId)
        {
            this.BookCollection.Remove(this.BookCollection.First(b => b.Id == bookId));
        }
    }
}
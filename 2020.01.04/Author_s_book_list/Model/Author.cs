using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Author_s_book_list.Enums;

namespace Author_s_book_list.Class
{
     public class Author:EntityBase
    {
        public string FirstName { get; set; }
        
        public string LastName { get; set; }

        public DateTime YearOfBirth { get; set; }

        public Language AuthorLanguage { get; set; }

        public Country Country { get; set; }

        public Country CountryOfBirth { get; set; }

        public State StateOfBirth { get; set; }

        public City CityOfBirth { get; set; }

        public ObservableCollection<Book> BookCollection { get; }

        public Author(string firstName, string lastName, DateTime yearOfBirth, Language language, Country country, Country countryOfBirth, State stateOfBirth, City cityOfBirth)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.YearOfBirth = yearOfBirth;
            this.AuthorLanguage = language;
            this.Country = country;
            this.CountryOfBirth = countryOfBirth;
            this.CityOfBirth = cityOfBirth;
            this.BookCollection = new ObservableCollection<Book>();
        }

        public void AddBook(Book book)
        {
            this.BookCollection.Add(book);
        }

        public void RemoveBook(int bookId)
        {
            //this.bookCollection.RemoveAt(this.bookCollection.IndexOf(this.bookCollection.First(b => b.Id == bookId)));
            this.BookCollection.Remove(this.BookCollection.First(b => b.Id == bookId));
        }

        public override string ToString()
        {
            return this.FirstName.ToString() + " " + this.LastName.ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Author_s_book_list.Class
{
    public class Book:EntityBase
    {
        public string Title { get; set; }

        public DateTime ReleaseDate { get; set; }

        public decimal Value { get; set; }

        public Book(string title, DateTime releaseDate, decimal value)
        {
            this.Title = title;
            this.ReleaseDate = releaseDate;
            this.Value = value;
        }

        public Book()
        {
        }
    }
}

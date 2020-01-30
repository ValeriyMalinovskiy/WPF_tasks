using System;

namespace Author_s_book_list.Class
{
    public class Book : EntityBase
    {
        public string Title { get; set; }

        public DateTime ReleaseDate { get; set; }

        public decimal Value { get; set; }

        public Book(string title, DateTime releaseDate, decimal value) : base(false)
        {
            this.Title = title;
            this.ReleaseDate = releaseDate;
            this.Value = value;
        }

        public Book()
        {
            this.ReleaseDate = DateTime.Today;
        }
    }
}

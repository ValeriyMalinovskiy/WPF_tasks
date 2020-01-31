using Author_s_book_list.Enums;
using System;

namespace Author_s_book_list.Class
{
    public class Book : EntityBase
    {
        public string Title { get; set; }

        public DateTime ReleaseDate { get; set; }

        public decimal Value { get; set; }

        public bool IsRead { get; set; }

        public DateTime ReadDate { get; set; }

        public Book(string title, DateTime releaseDate, decimal value) : base(false)
        {
            this.Title = title;
            this.ReleaseDate = releaseDate;
            this.Value = value;
            this.IsRead = true;
            this.ReadDate = DateTime.Today;
        }

        public Book()
        {
            this.ReleaseDate = DateTime.Today;
            this.IsRead = false;
            this.ReadDate = DateTime.MaxValue;
        }
    }
}

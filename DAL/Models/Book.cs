using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class Book
    {
        public Book()
        {
            BookAuthor = new HashSet<BookAuthor>();
            OrderLine = new HashSet<OrderLine>();
        }

        public int BookId { get; set; }
        public string Title { get; set; }
        public string Isbn13 { get; set; }
        public int? LanguageId { get; set; }
        public int? NumPages { get; set; }
        public DateTime? PublicationDate { get; set; }
        public int? PublisherId { get; set; }

        public virtual BookLanguage Language { get; set; }
        public virtual Publisher Publisher { get; set; }
        public virtual ICollection<BookAuthor> BookAuthor { get; set; }
        public virtual ICollection<OrderLine> OrderLine { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Models
{
    public partial class Book
    {
        public Book()
        {
            OrderLines = new HashSet<OrderLine>();
            Authors = new HashSet<Author>();
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
        public virtual ICollection<OrderLine> OrderLines { get; set; }

        public virtual ICollection<Author> Authors { get; set; }
    }
}

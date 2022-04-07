using System;
using System.Collections.Generic;

namespace Models
{
    public partial class BookLanguage
    {
        public BookLanguage()
        {
            Book = new HashSet<Book>();
        }

        public int LanguageId { get; set; }
        public string LanguageCode { get; set; }
        public string LanguageName { get; set; }

        public virtual ICollection<Book> Book { get; set; }
    }
}

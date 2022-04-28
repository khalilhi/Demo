using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class BookCategory
    {
        public BookCategory()
        {
            Book = new HashSet<Book>();
        }

        public int CategoryId { get; set; }
        public string CategoryCode { get; set; }
        public string CategoryName { get; set; }
        public string BckgroundColor { get; set; }

        public virtual ICollection<Book> Book { get; set; }
    }
}

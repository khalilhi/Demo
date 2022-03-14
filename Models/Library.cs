using System;
using System.Collections.Generic;

namespace Models
{
    public partial class Library
    {
        public Library()
        {
            Books = new HashSet<Book>();
        }

        public int Id { get; set; }
        public string Name { get; set; } 

        public virtual ICollection<Book> Books { get; set; }
    }
}

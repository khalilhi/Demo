using System;
using System.Collections.Generic;

namespace Models
{
    public partial class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int AuthorId { get; set; }
        public int PublisherId { get; set; }
        public int LibraryId { get; set; }

        public virtual Author Author { get; set; }
        public virtual Library Library { get; set; } 
        public virtual Publisher Publisher { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Models
{
    public partial class Author
    {
        public Author()
        {
            Books = new HashSet<Book>();
        }

        public int AuthorId { get; set; }
        public string AuthorName { get; set; }
        public int? UtilisateurId { get; set; }

        public virtual Utilisateur Utilisateur { get; set; }

        public virtual ICollection<Book> Books { get; set; }
    }
}

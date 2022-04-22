using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class Author
    {
        public Author()
        {
            BookAuthor = new HashSet<BookAuthor>();
        }

        public int AuthorId { get; set; }
        public string AuthorName { get; set; }
        public int? UtilisateurId { get; set; }

        public virtual Utilisateur Utilisateur { get; set; }
        public virtual ICollection<BookAuthor> BookAuthor { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Models
{
    public partial class Publisher
    {
        public Publisher()
        {
            Books = new HashSet<Book>();
        }

        public int PublisherId { get; set; }
        public string PublisherName { get; set; }
        public int? UtilisateurId { get; set; }

        public virtual Utilisateur Utilisateur { get; set; }
        public virtual ICollection<Book> Books { get; set; }
    }
}

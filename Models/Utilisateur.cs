using System;
using System.Collections.Generic;

namespace Models
{
    public partial class Utilisateur
    {
        public Utilisateur()
        {
            Authors = new HashSet<Author>();
            Customers = new HashSet<Customer>();
            Publishers = new HashSet<Publisher>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Tel { get; set; }
        public string Email { get; set; }
        public string MotPasse { get; set; }
        public bool IsRealPerson { get; set; }
        public bool IsHidden { get; set; }
        public bool CanBeDeleted { get; set; }
        public bool Annuler { get; set; }

        public virtual ICollection<Author> Authors { get; set; }
        public virtual ICollection<Customer> Customers { get; set; }
        public virtual ICollection<Publisher> Publishers { get; set; }
    }
}

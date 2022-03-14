using System;
using System.Collections.Generic;

namespace Models
{
    public partial class Customer
    {
        public Customer()
        {
            CustOrders = new HashSet<CustOrder>();
            CustomerAddresses = new HashSet<CustomerAddress>();
        }

        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int? UtilisateurId { get; set; }

        public virtual Utilisateur Utilisateur { get; set; }
        public virtual ICollection<CustOrder> CustOrders { get; set; }
        public virtual ICollection<CustomerAddress> CustomerAddresses { get; set; }
    }
}

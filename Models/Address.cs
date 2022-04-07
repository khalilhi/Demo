using System;
using System.Collections.Generic;

namespace Models
{
    public partial class Address
    {
        public Address()
        {
            CustOrder = new HashSet<CustOrder>();
            CustomerAddress = new HashSet<CustomerAddress>();
        }

        public int AddressId { get; set; }
        public string StreetNumber { get; set; }
        public string StreetName { get; set; }
        public string City { get; set; }
        public int? CountryId { get; set; }

        public virtual Country Country { get; set; }
        public virtual ICollection<CustOrder> CustOrder { get; set; }
        public virtual ICollection<CustomerAddress> CustomerAddress { get; set; }
    }
}

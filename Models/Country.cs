using System;
using System.Collections.Generic;

namespace Models
{
    public partial class Country
    {
        public Country()
        {
            Address = new HashSet<Address>();
        }

        public int CountryId { get; set; }
        public string CountryName { get; set; }

        public virtual ICollection<Address> Address { get; set; }
    }
}

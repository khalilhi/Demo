using System;
using System.Collections.Generic;

namespace Models
{
    public class AddressDto
    {

        public int AddressId { get; set; }
        public string StreetNumber { get; set; }
        public string StreetName { get; set; }
        public string City { get; set; }
        public int? CountryId { get; set; }
    }
}

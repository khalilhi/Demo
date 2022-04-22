using Models.Common;
using System;
using System.Collections.Generic;

namespace Models
{
    public class CustomerAddressDto : AbstractCusomModelNotifyBase
    {
        public int CustomerId { get; set; }
        public int AddressId { get; set; }
        public int? StatusId { get; set; }
    }
}

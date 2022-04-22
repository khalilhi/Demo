using Models.Common;
using System;
using System.Collections.Generic;

namespace Models
{
    public class CustOrderDto : AbstractCusomModelNotifyBase
    {

        public int OrderId { get; set; }
        public DateTime? OrderDate { get; set; }
        public int? CustomerId { get; set; }
        public int? ShippingMethodId { get; set; }
        public int? DestAddressId { get; set; }
    }
}

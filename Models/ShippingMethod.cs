using System;
using System.Collections.Generic;

namespace Models
{
    public partial class ShippingMethod
    {
        public ShippingMethod()
        {
            CustOrders = new HashSet<CustOrder>();
        }

        public int MethodId { get; set; }
        public string MethodName { get; set; }
        public decimal? Cost { get; set; }

        public virtual ICollection<CustOrder> CustOrders { get; set; }
    }
}

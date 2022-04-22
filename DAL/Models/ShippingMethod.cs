using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class ShippingMethod
    {
        public ShippingMethod()
        {
            CustOrder = new HashSet<CustOrder>();
        }

        public int MethodId { get; set; }
        public string MethodName { get; set; }
        public decimal? Cost { get; set; }

        public virtual ICollection<CustOrder> CustOrder { get; set; }
    }
}

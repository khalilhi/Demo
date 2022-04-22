using Models.Common;
using System;
using System.Collections.Generic;

namespace Models
{
    public class ShippingMethodDto  : AbstractCusomModelNotifyBase
    {

        public int MethodId { get; set; }
        public string MethodName { get; set; }
        public decimal? Cost { get; set; }
    }
}

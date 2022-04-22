using Models.Common;
using System;
using System.Collections.Generic;

namespace Models
{
    public class OrderLineDto  : AbstractCusomModelNotifyBase
    {
        public int LineId { get; set; }
        public int? OrderId { get; set; }
        public int? BookId { get; set; }
        public decimal? Price { get; set; }
    }
}

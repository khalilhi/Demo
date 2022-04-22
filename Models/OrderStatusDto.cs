using Models.Common;
using System;
using System.Collections.Generic;

namespace Models
{
    public class OrderStatusDto  : AbstractCusomModelNotifyBase
    {

        public int StatusId { get; set; }
        public string StatusValue { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Models
{
    public partial class OrderStatus
    {
        public OrderStatus()
        {
            OrderHistories = new HashSet<OrderHistory>();
        }

        public int StatusId { get; set; }
        public string StatusValue { get; set; }

        public virtual ICollection<OrderHistory> OrderHistories { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class OrderStatus
    {
        public OrderStatus()
        {
            OrderHistory = new HashSet<OrderHistory>();
        }

        public int StatusId { get; set; }
        public string StatusValue { get; set; }

        public virtual ICollection<OrderHistory> OrderHistory { get; set; }
    }
}

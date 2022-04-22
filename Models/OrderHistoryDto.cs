using Models.Common;
using System;
using System.Collections.Generic;

namespace Models
{
    public class OrderHistoryDto : AbstractCusomModelNotifyBase
    {
        public int HistoryId { get; set; }
        public int? OrderId { get; set; }
        public int? StatusId { get; set; }
        public DateTime? StatusDate { get; set; }
    }
}

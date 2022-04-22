using Models.Common;
using System;
using System.Collections.Generic;

namespace Models
{ 
    public partial class AddressStatusDto  : AbstractCusomModelNotifyBase
    {
        public int StatusId { get; set; }
        public string StatusName { get; set; }
    }
}

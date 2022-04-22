using Models.Common;
using System;
using System.Collections.Generic;

namespace Models
{
    public class BookAuthorDto  : AbstractCusomModelNotifyBase
    {
        public int BookId { get; set; }
        public int AuthorId { get; set; }
    }
}

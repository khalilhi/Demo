using Models.Common;
using System;
using System.Collections.Generic;

namespace Models
{
    public class PublisherDto  : AbstractCusomModelNotifyBase
    {

        public int PublisherId { get; set; }
        public string PublisherName { get; set; }
        public int? UtilisateurId { get; set; }

    }
}

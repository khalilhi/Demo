using Models.Common;
using System;
using System.Collections.Generic;

namespace Models
{
    public class AuthorDto  : AbstractCusomModelNotifyBase
    {
        public int AuthorId { get; set; }
        public string AuthorName { get; set; }
        public int? UtilisateurId { get; set; }
    }
}

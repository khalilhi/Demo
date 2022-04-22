using Models.Common;
using System;
using System.Collections.Generic;

namespace Models
{
    public class CustomerDto : AbstractCusomModelNotifyBase
    {

        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int? UtilisateurId { get; set; }
    }
}

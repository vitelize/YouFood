using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Security;

namespace Models
{
    class Personne : MembershipUser
    {
        public string Prenom { get; set; }
        public string Nom { get; set; }
        public string Password { get; set; }

        //
        public Restaurant restaurant { get; set; }
    }
}

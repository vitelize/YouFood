using System.Web.Security;

namespace Models
{
    public class Personne : MembershipUser
    {
        public string Prenom { get; set; }
        public string Nom { get; set; }
        public string Password { get; set; }

        //
        public Restaurant restaurant { get; set; }
    }
}

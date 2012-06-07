using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Security;
using Repository;
using Models;

namespace Metier
{
    public class GestionComptes : MembershipProvider
    {
        public Personne CreateUser(Personne personne, bool sendConfirmation)
        {
            Mail confirm;

            try
            {
                //GestionPersonne.Ajouter(personne);

                if (sendConfirmation)
                {
                    confirm = new Mail();

                    confirm.Destinataire = personne.Email;

                    confirm.Titre = "Bienvenue à YouFood Restaurant";

                    confirm.Message = "bla bla bla bienvenue chez YouFood, cher ....... et pas tati et pas tata et compagnil";

                    confirm.envoyer();
                }
            }
            catch (Exception e)
            {
                throw new Exception("Echec Metier : Echec Creation Nouvel Utilisateur", e);
            }

            return null;
        }

        public override bool ValidateUser(string username, string password)
        {
            try
            {
                //Personne personne = GestionPersonne.RecupererParEmailEtPassword(username, password);

                /*if (personne != null)
                    return true;
                else
                    return false;*/

                return false;
            }
            catch (Exception e)
            {
                throw new Exception("Erreur Metier : Echec Authentification Utilisateur avec l'email : " + username, e);
            }
        }

        public override string ApplicationName
        {
            get
            {
                return "Gestion Comptes";
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public override bool ChangePassword(string username, string oldPassword, string newPassword)
        {
            throw new NotImplementedException();
        }

        public override bool ChangePasswordQuestionAndAnswer(string username, string password, string newPasswordQuestion, string newPasswordAnswer)
        {
            throw new NotImplementedException();
        }

        public override MembershipUser CreateUser(string username, string password, string email, string passwordQuestion, string passwordAnswer, bool isApproved, object providerUserKey, out MembershipCreateStatus status)
        {

            status = MembershipCreateStatus.DuplicateEmail;

            return null;
        }

        public override bool DeleteUser(string username, bool deleteAllRelatedData = true)
        {
            try
            {
                //GestionPersonne.Supprimer(GestionPersonne.RecupererParNom(username));
                return true;
            }
            catch (Exception e)
            {
                throw new Exception("Erreur Metier : Echec Suppression Utilisateur au nom : " + username, e);
            }
            
        }

        public override bool EnablePasswordReset
        {
            get { throw new NotImplementedException(); }
        }

        public override bool EnablePasswordRetrieval
        {
            get { throw new NotImplementedException(); }
        }

        public override MembershipUserCollection FindUsersByEmail(string emailToMatch, int pageIndex, int pageSize, out int totalRecords)
        {
            throw new NotImplementedException();
        }

        public override MembershipUserCollection FindUsersByName(string usernameToMatch, int pageIndex, int pageSize, out int totalRecords)
        {
            throw new NotImplementedException();
        }

        public override MembershipUserCollection GetAllUsers(int pageIndex, int pageSize, out int totalRecords)
        {
            throw new NotImplementedException();
        }

        public override int GetNumberOfUsersOnline()
        {
            throw new NotImplementedException();
        }

        public override string GetPassword(string username, string answer)
        {
            throw new NotImplementedException();
        }

        public override MembershipUser GetUser(string username, bool userIsOnline = true)
        {
            throw new NotImplementedException();
        }

        public override MembershipUser GetUser(object providerUserKey, bool userIsOnline)
        {
            throw new NotImplementedException();
        }

        public override string GetUserNameByEmail(string email)
        {
            throw new NotImplementedException();
        }

        public override int MaxInvalidPasswordAttempts
        {
            get { return 6; }
        }

        public override int MinRequiredNonAlphanumericCharacters
        {
            get { throw new NotImplementedException(); }
        }

        public override int MinRequiredPasswordLength
        {
            get { return 6; }
        }

        public override int PasswordAttemptWindow
        {
            get { throw new NotImplementedException(); }
        }

        public override MembershipPasswordFormat PasswordFormat
        {
            get { throw new NotImplementedException(); }
        }

        public override string PasswordStrengthRegularExpression
        {
            get { throw new NotImplementedException(); }
        }

        public override bool RequiresQuestionAndAnswer
        {
            get { throw new NotImplementedException(); }
        }

        public override bool RequiresUniqueEmail
        {
            get { 
                throw new NotImplementedException(); 
            }
        }

        public override string ResetPassword(string username, string answer)
        {
            throw new NotImplementedException();
        }

        public override bool UnlockUser(string userName)
        {
            throw new NotImplementedException();
        }

        public override void UpdateUser(MembershipUser user)
        {
            throw new NotImplementedException();
        }
    }
}

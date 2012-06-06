using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using Poco;

namespace Repository
{
    public static class GestionPersonne
    {
        public static void Ajouter(Personne personne)
        {
            try
            {
                using (var context = new ModelContainer())
                {
                    context.PersonneJeu.AddObject(personne);
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception("Erreur Repository : Echec Creation Personne", e);
            }
        }

        public static void Supprimer (Personne personne)
        {
            try
            {
                using (var context = new ModelContainer())
                {
                    context.PersonneJeu.DeleteObject(personne);
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception("Erreur Repository : Echec Suppression Personne à " + personne.ID, e);
            }
        }

        public static void Supprimer (int personneId)
        {
            try
            {
                Personne personne = RecupererParID(personneId);

                using (var context = new ModelContainer())
                {
                    context.PersonneJeu.DeleteObject(personne);
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception("Erreur Repository : Echec Suppression Personne à l'id : " + personneId, e);
            }
        }

        public static List<Personne> RecupererTous ()
        {
            try
            {
                using (var context = new ModelContainer())
                {
                    return context.PersonneJeu.ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception("Erreur Repository : Echec lecture de toutes les personnes", e);
            }
        }

        public static Personne RecupererParID (int personneID)
        {
            try
            {
                using (var context = new ModelContainer())
                {
                    return (from p in context.PersonneJeu
                            where p.ID == personneID
                            select p).SingleOrDefault();
                }
            }
            catch (Exception e)
            {
                throw new Exception("Erreur Repository: Echec lecture personne à l'id : " + personneID, e);
            }
        }

        public static Personne RecupererParNom(string nom)
        {
            try
            {
                using (var context = new ModelContainer())
                {
                    return (from p in context.PersonneJeu
                            where p.Nom == nom
                            select p).SingleOrDefault();
                }
            }
            catch (Exception e)
            {
                throw new Exception("Erreur Repository: Echec lecture personne au nom : " + nom, e);
            }
        }

        public static Personne RecupererParEmail(string email)
        {
            try
            {
                using (var context = new ModelContainer())
                {
                    return (from p in context.PersonneJeu
                            where p.Email == email
                            select p).SingleOrDefault();
                }
            }
            catch (Exception e)
            {
                throw new Exception("Erreur Repository: Echec lecture personne à l'email : " + email, e);
            }
        }

        public static Personne RecupererParEmailEtPassword(string email, string password)
        {
            try
            {
                using (var context = new ModelContainer())
                {
                    return (from p in context.PersonneJeu
                            where p.Email == email && p.Password == password
                            select p).SingleOrDefault();
                }
            }
            catch (Exception e)
            {
                throw new Exception("Erreur Repository: Echec lecture à l'email : " + email, e);
            }
        }

        public static void MAJPersonne (Personne personne)
        {
            try
            {
                using (var context = new ModelContainer())
                {
                    context.PersonneJeu.ApplyCurrentValues(personne);
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception("Erreur Repository : Echec MAJ Personne à l'id : " + personne.ID, e);
            }
        }
    }
}

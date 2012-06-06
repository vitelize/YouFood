using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Poco;

namespace Repository
{
    public static class GestionCarte
    {
        public static void Ajouter(Carte carte)
        {
            try
            {
                using (var context = new ModelContainer())
                {
                    context.CarteJeu.AddObject(carte);
                    context.SaveChanges();
                }
            }

            catch (Exception e)
            {
                throw new Exception("Erreur repository : erreur de creation de carte", e);
            }
        }

        public static void Supprimer(Carte carte)
        {
            try
            {
                GestionCarte.Supprimer(carte.ID);
            }

            catch (Exception e)
            {
                throw new Exception("Erreur repository : erreur de suppression de carte", e);
            }
        }

        public static void Supprimer(int carteId)
        {
            Carte carte = null;

            using (var context = new ModelContainer())
            {
                try
                {
                    carte = (from c in context.CarteJeu
                                  where c.ID == carteId
                                  select c).FirstOrDefault();
                }
                catch (Exception e)
                {
                    throw new Exception("Erreur Respository : SupprimerCarte : Echec Recuperation Carte", e);
                }

                if (carte == null)
                    throw new Exception("Erreur Respository : SupprimerCarte : ");

                try
                {
                    context.DeleteObject(carte);
                    context.SaveChanges();
                }
                catch (Exception e)
                {
                    throw new Exception("Erreur repository : erreur de suppression de restaurant", e);
                }
            }
        }

        public static List<Carte> RecupererTous()
        {
            try
            {
                using (var context = new ModelContainer())
                {
                    return context.CarteJeu.ToList();
                }
            }

            catch (Exception e)
            {
                throw new Exception("Erreur repository : erreur de lecture de toutes les cartes", e);
            }
        }   

        public static Carte RecupereParID(int carteID)
        {
            try
            {
                using (var context = new ModelContainer())
                {
                    return context.CarteJeu.First(c => c.ID == carteID);
                }
            }

            catch (Exception e)
            {
                throw new Exception("Erreur repository : erreur de lecture de carte par son ID", e);
            }
        }

        public static void MAJCarte(Carte carte)
        {
            try
            {
                using (var context = new ModelContainer())
                {
                    Carte CarteOriginal = context.CarteJeu.First(c => c.ID == carte.ID);
                    context.CarteJeu.ApplyCurrentValues(carte);
                    context.SaveChanges();
                }
            }

            catch (Exception e)
            {
                throw new Exception("Erreur repository : erreur de mise a jour de carte", e);
            }
        }
    }
}

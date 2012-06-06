using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Poco; 

namespace Repository
{
    public static class GestionNotification
    {

        public static void Ajouter(Notification notification)
        {
            try
            {
                using (var context = new ModelContainer())
                {
                    context.NotificationJeu.AddObject(notification);
                    context.SaveChanges();
                }
            }

            catch (Exception e)
            {
                throw new Exception("Erreur repository : erreur de creation de notification", e);
            }
        }

        public static void AckNotification(Notification notification)
        {
            try
            {
                using (var context = new ModelContainer())
                {
                    Notification NotificationOriginal = context.NotificationJeu.First(c => c.ID == notification.ID);
                    context.NotificationJeu.ApplyCurrentValues(notification);
                    context.SaveChanges();
                }
            }

            catch (Exception e)
            {
                throw new Exception("Erreur repository : erreur de mise a jour de restaurant", e);
            }
            
        }

        public static List<Notification> RecupererTous()
        {
            try
            {
                using (var context = new ModelContainer())
                {
                    return context.NotificationJeu.ToList();
                }
            }

            catch (Exception e)
            {
                throw new Exception("Erreur repository : erreur de lecture de toutes les Notifications", e);
            }
        }

        public static List<Notification> RecupererAFaireParUser(int userId)
        {
            using (var context = new ModelContainer())
            {
                try
                {
                    return (from n in context.NotificationJeu
                                    where n.ID == userId
                                  select n).ToList();
                }
                catch (Exception e)
                {
                    throw new Exception("Erreur Respository : RecupererAFaireParUser : Echec Recuperation liste notifications", e);
                }
            }
        }

        public static List<Notification> RecupererParType(int typeId)
        {
            using (var context = new ModelContainer())
            {
                try
                {
                    return (from n in context.NotificationJeu
                            where n.TypeNotification.ID == typeId
                            select n).ToList();
                }
                catch (Exception e)
                {
                    throw new Exception("Erreur Respository : RecupererAFaireParUser : Echec Recuperation liste notifications", e);
                }
            }
        } 


    }
}

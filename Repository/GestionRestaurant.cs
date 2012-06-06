using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Poco; 

namespace Repository
{
    public static class GestionRestaurant
    {
        public static void Ajouter(Restaurant restaurant)
        {
            try
            {
                using (var context = new ModelContainer())
                {
                    context.RestaurantJeu.AddObject(restaurant);
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception("Erreur repository : erreur de creation de restaurant", e);
            } 
        }

        public static void Supprimer(Restaurant restaurant)
        {
            try
            {
                using (var context = new ModelContainer())
                {
                    context.RestaurantJeu.DeleteObject(restaurant);
                    context.SaveChanges();
                }
            }

            catch (Exception e)
            {
                throw new Exception("Erreur repository : erreur de suppression de restaurant", e);
            }
        }

        public static void Supprimer (int restaurantId)
        {
            Restaurant restaurant = null;
            
            using (var context = new ModelContainer())
            {
                GestionRestaurant.RecupererParID(restaurantId);   
            
                if (restaurant == null)
                    throw new Exception ("Erreur Respository : SupprimerRestaurant : ");

                    try
                    {
                        context.DeleteObject(restaurant);
                        context.SaveChanges();
                    }
                    catch (Exception e)
                    {
                        throw new Exception("Erreur repository : erreur de suppression de restaurant", e);
                    }
                }
            }

        public static List<Restaurant> RecupererTous()
        {
            try
            {
                using (var context = new ModelContainer())
                {
                    return context.RestaurantJeu.ToList();
                }
            }

            catch (Exception e)
            {
                throw new Exception("Erreur repository : erreur de lecture de tous les restaurants", e);
            }
        }   

        public static Restaurant RecupererParID(int restaurantID)
        {
            try
            {
                using (var context = new ModelContainer())
                {
                    return context.RestaurantJeu.First(c => c.ID == restaurantID);
                }
            }

            catch (Exception e)
            {
                throw new Exception("Erreur repository : erreur de lecture de restaurant par son ID", e);
            }
        }

        public static void MAJRestaurant(Restaurant restaurant)
        {
            try
            {
                using (var context = new ModelContainer())
                {
                    Restaurant RestaurantOriginal = context.RestaurantJeu.First(c => c.ID == restaurant.ID);
                    context.RestaurantJeu.ApplyCurrentValues(restaurant);
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception("Erreur repository : erreur de mise a jour de restaurant", e);
            }
        }   
    }
}

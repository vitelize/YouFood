using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using Models;

namespace Repository
{
    public static class Restaurant_Repo
    {
        public static void Ajouter(Restaurant restaurant)
        {
            try
            {
                using (Context db = new Context())
                {
                    db.Restaurants.Add(restaurant);
                    db.SaveChanges();
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
                using (Context db = new Context())
                {
                    db.Restaurants.Remove(restaurant);
                    db.SaveChanges();
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
            
            using (Context db = new Context())
            {
                Restaurant_Repo.RecupererParID(restaurantId);   
            
                if (restaurant == null)
                    throw new Exception ("Erreur Respository : SupprimerRestaurant : ");

                    try
                    {
                        db.Restaurants.Remove(restaurant);
                        db.SaveChanges();
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
                using (Context db = new Context())
                {
                    return db.Restaurants.ToList();
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
                using (Context db = new Context())
                {
                    return db.Restaurants.First(c => c.ID == restaurantID);
                }
            }

            catch (Exception e)
            {
                throw new Exception("Erreur repository : erreur de lecture de restaurant par son ID", e);
            }
        }

        /*public static void MAJRestaurant(Restaurant restaurant)
        {
            try
            {
                using (Context db = new Context())
                {
                    Restaurant RestaurantOriginal = db.Restaurants.First(c => c.ID == restaurant.ID);
                    db.Restaurants.ApplyCurrentValues(restaurant);
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception("Erreur repository : erreur de mise a jour de restaurant", e);
            }
        }  */ 
    }
}

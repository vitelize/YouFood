using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Poco;

namespace Metier
{
    public static class GestionMetierCarte
    {
        public static Carte RecupererParSpecialiteId(int id)
        {
            try
            {
                using (var context = new ModelContainer())
                {
                    return context.CarteJeu.First(c => c.ID == id);
                }
            }

            catch (Exception e)
            {
                throw new Exception("Erreur repository : erreur de lecture de la carte par l'ID de la specialite", e);
            }
        }
    }
}

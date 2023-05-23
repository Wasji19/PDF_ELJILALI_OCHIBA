using System;
using System.Collections.Generic;
using System.Text;

namespace PDF_Wassim
{
    class Poulailler
    {
        /// <summary>
        /// Nom donné au Poulailler
        /// </summary>
        /// <example>Paris,Marseille,Amiens,Annecy,etc</example>
        string nomPoulailler;
        
     
        /// <summary>
        /// capacité maximale d'un poulailler
        /// </summary>
        /// <example>la capacité maximale du Poulailler Annecy est de 15 poules </example>
        int capaciteMax;
        /// <summary>
        /// liste de poule necessair a l'ajout de poule dans le poulailler
        /// </summary>
        /// <example>ginger,klass,Taz </example>
        List<Poule> poules;


        /// <summary>
        /// Création d'une nouvelle instance d'un objet Poulailler
        /// </summary>
        /// <param name="nomPll">Nom du Poulailler</param>
        /// <param name="capMax">capacité maximale d'un seul Poulailler</param>
        public Poulailler(string nomPll, int capMax )
        {
            nomPoulailler = nomPll;
            capaciteMax = capMax;
            poules = new List<Poule>();

        }
        public void Afficher()
        {
            Console.WriteLine($"Poulailler {nomPoulailler}: la capacité maximale du poulailler {nomPoulailler} est de {capaciteMax}");
        }
        public void AjouterPoule(Poule poule)
        {
            if (poules.Count < capaciteMax)
            {
                poules.Add(poule);
                Console.WriteLine($"La poule {poule.Nom} a été ajoutée au poulailler {nomPoulailler}.");
            }
            else
            {
                Console.WriteLine($"Le poulailler {nomPoulailler} est déjà à sa capacité maximale de {capaciteMax} poules. Impossible d'ajouter une nouvelle poule.");
            }
        }
    }
}

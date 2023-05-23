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
            Console.WriteLine($"Liste des poules dans le poulailler {nomPoulailler}:");
            foreach (Poule poule in poules)
            {
                Console.WriteLine(poule.Nom);
            }
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


        public int NombreRacesDistinctes()
        {
            List<string> racesDistinctes = new List<string>();

            for (int i = 0; i < poules.Count; i++)
            {
                string raceActuelle = poules[i].Race;
                bool raceDejaComptee = false;

                for (int j = 0; j < i; j++)
                {
                    if (poules[j].Race == raceActuelle)
                    {
                        raceDejaComptee = true;
                        break;
                    }
                }

                if (!raceDejaComptee)
                {
                    racesDistinctes.Add(raceActuelle);
                }
            }

            return racesDistinctes.Count;
        }
    }
}

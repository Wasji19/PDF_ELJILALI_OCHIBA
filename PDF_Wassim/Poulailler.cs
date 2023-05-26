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
        /// Création d'un Poulailler
        /// </summary>
        /// <param name="nomPll">Nom du Poulailler</param>
        /// <param name="capMax">capacité maximale d'un seul Poulailler</param>
        public Poulailler(string nomPll, int capMax )
        {
            nomPoulailler = nomPll;
            capaciteMax = capMax;
            poules = new List<Poule>();

        }

        /// <summary>
        /// methode afficher qui affiche le Poulailler,sa capacité maxiamle,le nombre de poule et la liste des poules ajoutée
        /// </summary>
        public void Afficher()
        {
            Console.WriteLine();
            Console.WriteLine($"Poulailler {nomPoulailler}: la capacité maximale du poulailler {nomPoulailler} est de {capaciteMax}");
            Console.WriteLine($"Il y a {poules.Count} poules"); 
            Console.WriteLine($"Liste des poules dans le poulailler {nomPoulailler}:");
            int emplacement = 0;
            foreach (Poule poule in poules)
            {
                Console.WriteLine($"ID: {emplacement}, Nom: {poule.Nom}, Race: {poule.Race}");
                emplacement++;
            }
        }

        /// <summary>
        /// methode qui ajoute la poule au poulailler
        /// </summary>
        /// <param name="poule">objet poule</param>
        public void AjouterPoule(Poule poule)
        {
            if (poules.Count < capaciteMax)
            {
                poules.Add(poule);
                Console.WriteLine($"La poule {poule.Nom} a été ajoutée au poulailler {nomPoulailler}.");
               
            }
            else
            {
                Console.WriteLine($"Le poulailler {nomPoulailler} est déjà à sa capacité maximale de {capaciteMax} poules. Impossible d'ajouter une nouvelle poule.\n");
            }
     
        
        }
        /// <summary>
        /// methode qui supprime une poule en fonction de son numero d'identification
        /// </summary>
        /// <param name="id">numero d'indentification de la poule</param>
        public void SupprimerPoule(int id)
        {
            try
            {
                poules.RemoveAt(id);
            } catch
            {
                Console.WriteLine("Impossible d'effectuer la suppresion");
            }
        }
        /// <summary>
        /// Methode de deplcement d'une poule vers un autre poulailler
        /// </summary>
        /// <param name="poule">Poule qu'on veut deplacer</param>
        /// <param name="autrePoulailler">Poulailler de destination</param>
        public void DeplacerPoule(Poule poule, Poulailler autrePoulailler)
        {
            if (!poules.Contains(poule))
            {
                Console.WriteLine($"Le poulailler {nomPoulailler} ne contient pas la poule {poule.Nom}. Impossible de la déplacer.");
                return;
            }

            if (autrePoulailler.poules.Count >= autrePoulailler.capaciteMax)
            {
                Console.WriteLine($"Le poulailler {autrePoulailler.nomPoulailler} est déjà à sa capacité maximale de {autrePoulailler.capaciteMax} poules. Impossible de déplacer la poule.");
                return;
            }
            Console.WriteLine();
            poules.Remove(poule);
            autrePoulailler.AjouterPoule(poule);
            Console.WriteLine($"La poule {poule.Nom} a été déplacée du poulailler {nomPoulailler} vers le poulailler {autrePoulailler.nomPoulailler}.");
        }

    }
}

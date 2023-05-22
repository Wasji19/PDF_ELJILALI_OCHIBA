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
        ///Objet Poule
        /// </summary>
        /// <example>Ginger,taz,klass</example>
        Poule poulePll;
        /// <summary>
        /// le nombre de race dans un meme Poulailler
        /// </summary>
        /// <example>3 gantoise, 2 Vorwerk, 5 Sussex, etc </example>
        int nbr_de_race;
        /// <summary>
        /// capacité maximale d'un poulailler
        /// </summary>
        /// <example>la capacité maximale du Poulailler Annecy est de 15 poules </example>
        int capaciteMax;


        /// <summary>
        /// Création d'une nouvelle instance d'un objet Poulailler
        /// </summary>
        /// <param name="nomPll">Nom du Poulailler</param>
        /// <param name="nbr_Race_pll">Nombre de races de poules presente dans un seul Poulailler</param>
        /// <param name="capMax">capacité maximale d'un seul Poulailler</param>
        public Poulailler(string nomPll, int nbr_Race_pll, int capMax, Poule poule )
        {
            nomPoulailler = nomPll;
            nbr_de_race = nbr_Race_pll;
            capaciteMax = capMax;
            poulePll = poule;
           
        }
        public void Afficher()
        {
            Console.WriteLine($"Poulailler {nomPoulailler}: la capacité maximale du poulailler {nomPoulailler} est de {capaciteMax}, il y a {nbr_de_race} races de poules dans le Poulailler {nomPoulailler},{poulePll}");
        }
    }
}

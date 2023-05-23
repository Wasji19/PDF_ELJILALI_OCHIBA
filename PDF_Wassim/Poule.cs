using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDF_Wassim
{
  
        /// <summary>
        /// Modélise une poule
        /// </summary>
        public class Poule
        {
            /// <summary>
            /// Nom de la poule
            /// </summary>
            /// <example>Germaine, Roussette, Ginger, Raymonde</example>
            string nom;
            /// <summary>
            /// Race de la poule
            /// </summary>
            /// <example>Sussex, Marans, Gatinaise, Gauloise</example>
            string race;
            /// <summary>
            /// Nb moyen d'oeufs pondus par jour
            /// </summary>
            double intensitePonte;
            /// <summary>
            /// Taille de la poule
            /// </summary>
            /// <remarks>S jusque XXL</remarks>
            Taille taille;

            /// <summary>
            /// Création d'une nouvelle instance d'un objet Poule
            /// </summary>
            /// <param name="nomP">Nom</param>
            /// <param name="raceP">Race</param>
            /// <param name="intensiteP">Intensite de ponte</param>
            /// <param name="tailleP">Taille</param>
            public Poule(string nomP, string raceP, double intensiteP, Taille tailleP)
            {
                nom = nomP;
                race = raceP;
                intensitePonte = intensiteP;
                taille = tailleP;
            }

        public string Nom { get => nom; set => nom = value; }
        public string Race { get => race; set => race = value; }
        public string Race1 { get => race; set => race = value; }

        /// <summary>
        /// Affiche le nom et la race
        /// </summary>
        public void Afficher()
            {
                Console.WriteLine($"{nom} ({race})");
            }
        }
    }

using System;

namespace PDF_Wassim
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instanciation d'un poule Ginger
            Poule ginger = new Poule("Ginger", "gauloise", 0.8, Taille.L);
            Poule taz = new Poule("Taz", "Charoloise", 2.4, Taille.XL);
            Poule klass = new Poule("Klass", "Penedesenca", 1.2, Taille.M);

            Poulailler Annecy = new Poulailler("Annecy", 4, 15,ginger);
            Poulailler Paris = new Poulailler("Paris", 5, 25, taz);
            Poulailler Amiens= new Poulailler("Amiens", 3, 17, klass);

            // Affichage du Poulailler
            Annecy.Afficher();
           ginger.Afficher();
        }
    }
}

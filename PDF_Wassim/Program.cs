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

            Poulailler Annecy = new Poulailler("Annecy",5);
            Poulailler Paris = new Poulailler("Paris", 3);
            Poulailler Amiens= new Poulailler("Amiens", 2);
            Annecy.AjouterPoule(ginger);
            Paris.AjouterPoule(taz);
            Annecy.AjouterPoule(klass);
            // Affichage du Poulailler
            Annecy.Afficher();
           
        }
    }
}

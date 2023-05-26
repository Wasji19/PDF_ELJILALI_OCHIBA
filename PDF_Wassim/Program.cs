using System;

namespace PDF_Wassim
{
    class Program
    {
        static void Main(string[] args)
        {
            

            // Instanciation d'une poule 
            Poule ginger = new Poule("Ginger", "gauloise", 0.8, Taille.L);
            Poule taz = new Poule("Taz", "Charoloise", 2.4, Taille.XL);
            Poule klass = new Poule("Klass", "Penedesenca", 1.2, Taille.M);
            Poule Frost = new Poule("Frost", "Marans", 0.0, Taille.S);
            Poule Bawita = new Poule("Bawita", "Burma ", 1.0, Taille.S);
            Poule Aknani = new Poule("Aknani", "Brahma", 3.1, Taille.XXL);

            //Instanciation d'un Poulailler
            Poulailler Annecy = new Poulailler("Annecy",5);
            Poulailler Paris = new Poulailler("Paris", 3);
            Poulailler Amiens= new Poulailler("Amiens", 2);
            
            //Ajout des poules dans les poulaillers
            Annecy.AjouterPoule(ginger);
            Annecy.AjouterPoule(klass);
            Paris.AjouterPoule(taz);
            Paris.AjouterPoule(Frost);
            Amiens.AjouterPoule(Bawita);
            Amiens.AjouterPoule(Aknani);
            //Affichage simple 
            Amiens.Afficher();

            // Affichage du Poulailler et du test de la methode SupprimerPoule
            Annecy.Afficher();
            Annecy.SupprimerPoule(1);
            Annecy.Afficher();
            // Affichage du Poulailler et du test de la methode SupprimerPoule dans le cas ou il n'y a pas de poule a l'emplacement saisie
            Paris.Afficher();
            Paris.SupprimerPoule(5);
            Paris.Afficher();
            //deplacement d'une poule vers un autre poulailler
            Annecy.DeplacerPoule(ginger, Paris);
            Annecy.Afficher();
            Paris.Afficher();


        }
    }
}

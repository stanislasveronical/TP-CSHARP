using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using dllBibliothèque;


namespace GestionBibliothèque
{
    class Program
    {
        static void Main(string[] args)
        {
            Bibliotheque b = Bibliotheque.CreateBibliotheque(@"U:\Slam2\bibliotheque\bibliotheque.txt");
            char choix = ' ';
            while (choix != 'z')
            {
                choix = Menu();
                Traiter(choix, b);
                Console.ReadLine();
                Console.Clear();
            }
        }

        private static char Menu()
        {
            char choix;
            Console.WriteLine("0 : Caractéristiques de la bibliothèque");
            Console.WriteLine("1 : Liste des livres");
            Console.WriteLine("2 : Liste des auteurs");
            Console.WriteLine("3 : Liste des livres avec leur auteur");
            Console.WriteLine("4 : Rechercher un livre par sa position");
            Console.WriteLine("5 : Rechercher un livre par son titre");
            Console.WriteLine("6 : Créer un Livre et son auteur");
            Console.WriteLine("7 : Créer un Livre en choisissant son auteur");
            Console.WriteLine("8 : Supprimer un Livre");
            Console.WriteLine("9 : Liste des Livres parus avant");
            Console.WriteLine("a : Liste des livres d'un genre");
            Console.WriteLine("b : Liste des livres d'un auteur");
            Console.WriteLine("y : Enregistrer les modifications");
            Console.WriteLine("z : Quitter \n");
            Console.Write("Votre choix : ");

            choix = Console.ReadLine()[0];
            return choix;
        }

        private static void Traiter(char choix, Bibliotheque b)
        {
            Console.WriteLine("");
            switch (choix)
            {
                case '0':
                    CaracteristiqueBibliotheque(b);
                    break;
                case '1':
                    AfficherLivres(b);
                    break;
                case '2':
                    AfficherAuteurs(b);
                    break;
                case '3':
                    AfficherLivresAuteur(b);
                    break;
                case '4':
                    RechercheLivrePosition(b);
                    break;
                case '5':
                    RechercheLivreTitre(b);
                    break;
                case '6':
                    CreerLivreAuteur(b);
                    break;
                case '7':
                    CreerLivreChoixAuteur(b);
                    break;
                case '8':
                    SupprimerLivre(b);
                    break;
                case '9':
                    ListeLivreDateParution(b);
                    break;
                case 'a':
                    ListeLivreGenre(b);
                    break;
                case 'b':
                    ListeLivreAuteur(b);
                    break;
                case 'y':
                    EnregistrerBibliotheque(b);
                    break;
            }
            if (choix != 'z')
            {
                Console.Write("continuer...");
            }
        }

        private static void EnregistrerBibliotheque(Bibliotheque b)
        {
            //throw new NotImplementedException();
            b.EnregistrerBibliotheque();
            Console.WriteLine("Les modifications faites sur la base ont été enregistrés dans le fichier");
        }

        private static void ListeLivreAuteur(Bibliotheque b)
        {
            //throw new NotImplementedException();
            Console.WriteLine("NOM/PRENOM");
            int i;
            for (i = 0; i < b.GetCountAuteurs(); i++)
            {
                Auteur a = b.GetAuteur(i);
                Console.WriteLine("{0}/{1}", a.GetNom(), a.GetPrenom());

            }

            Console.WriteLine("Choisissez un auteur");
            string s = Console.ReadLine();
            
        }

        private static void ListeLivreGenre(Bibliotheque b)
        {
            //throw new NotImplementedException();
            Console.WriteLine("Saisissez un genre : ");
            string s = Console.ReadLine();

        }

        private static void ListeLivreDateParution(Bibliotheque b)
        {
            //throw new NotImplementedException();
            Console.WriteLine("Saisissez une année : ");
            string s = Console.ReadLine();
            Console.WriteLine(b.GetLivre(s));
        }

        private static void SupprimerLivre(Bibliotheque b)
        {
            //throw new NotImplementedException();
            Console.WriteLine("TITRE/GENRE/DATE/PARUTION/NOM AUTEUR/PRENOM AUTEUR");
            int i;
            for (i = 0; i < b.GetCountLivres(); i++)
            {
                Livre l = b.GetLivre(i);
                Console.WriteLine("{0}/{1}/{2}/{3}", l.GetTitre(), l.GetGenre(), l.GetAnneeSortie(), l.GetAuteur());

            }
            string s;
            int k;
            Console.WriteLine("Saisissez un numéro : ");
            s = Console.ReadLine();
            k = Convert.ToInt32(s);

            Console.WriteLine(b.GetLivre(k));

            b.SupprimerLivre(k);
        }

        private static void CreerLivreChoixAuteur(Bibliotheque b)
        {
            //throw new NotImplementedException();
            Console.WriteLine("NOM/PRENOM");
            int i;
            for (i = 0; i < b.GetCountAuteurs(); i++)
            {
                Auteur a = b.GetAuteur(i);
                Console.WriteLine("{0}/{1}", a.GetNom(), a.GetPrenom());

            }

                        
            Console.WriteLine("Choisissez un auteur : ");
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();
            //Auteur A = b.GetAuteur(s1, s2);
            

            Console.WriteLine("Saisissez pour le livre le TITRE : ");
            string z1 = Console.ReadLine();

            Console.WriteLine("Saisissez pour le livre le GENRE : ");
            string z2 = Console.ReadLine();

            Console.WriteLine("Saisissez pour le livre la DATE DE PARUTION : ");
            string z3 = Console.ReadLine();
            int z3int = Convert.ToInt32(s1);

            //b.AjouterLivre(z1, z2, A, z3int);


        }

        private static void CreerLivreAuteur(Bibliotheque b)
        {
            //throw new NotImplementedException();
            Auteur A;

            Console.WriteLine("Saisissez pour l'auteur le NOM : ");
            string s1 = Console.ReadLine();

            Console.WriteLine("Saisissez pour l'auteur le PRENOM : ");
            string s2 = Console.ReadLine();

            Console.WriteLine("Saisissez pour l'auteur l'ANNEE DE NAISSANCE : ");
            string s3 = Console.ReadLine();
            int s3int = Convert.ToInt32(s3);
            
            
            Console.WriteLine("Saisissez pour l'auteur l'ANNEE DE DECES : ");
            string s4 = Console.ReadLine();
            int s4int = Convert.ToInt32(s4);

            Console.WriteLine("L'Auteur est instancié");
            string s = Console.ReadLine();
            A = Auteur.CreateAuteur(s3int, s4int, s1, s2);

            Livre L;

            Console.WriteLine("Saisissez pour le livre le TITRE : ");
            string z1 = Console.ReadLine();

            Console.WriteLine("Saisissez pour le livre le GENRE : ");
            string z2 = Console.ReadLine();

            Console.WriteLine("Saisissez pour le livre la DATE DE PARUTION : ");
            string z3 = Console.ReadLine();
            int z3int = Convert.ToInt32(s3);

            Console.WriteLine("Le livre est ajouté à la bibliotèque");
            string z = Console.ReadLine();
            L = Livre.CreateLivre(z1, z2, A, z3int);

            b.AjouterLivre(z1, z2, A, z3int);
        }

        private static void RechercheLivreTitre(Bibliotheque b)
        {
            //throw new NotImplementedException();
            
            
            string s;
            Console.WriteLine("Saisissez le titre d'un livre : ");
            s = Console.ReadLine();

            Console.WriteLine(b.GetLivre(s));
          
            Console.WriteLine("Le livre n'est pas présent !");

        }

        private static void RechercheLivrePosition(Bibliotheque b)
        {
            //throw new NotImplementedException();
            string s;
            int i;
            Console.WriteLine("Saisissez un numéro : ");
            s = Console.ReadLine();
            i = Convert.ToInt32(s);

            Console.WriteLine(b.GetLivre(i));
        
        }

        private static void AfficherLivresAuteur(Bibliotheque b)
        {
            //throw new NotImplementedException();
            Console.WriteLine("TITRE/GENRE/DATE/PARUTION/NOM AUTEUR/PRENOM AUTEUR");
            int i;
            for (i = 0; i < b.GetCountLivres(); i++)
            {
                Livre l = b.GetLivre(i);
                Console.WriteLine("{0}/{1}/{2}/{3}", l.GetTitre(), l.GetGenre(), l.GetAnneeSortie(), l.GetAuteur());

            }
        }

        private static void AfficherAuteurs(Bibliotheque b)
        {
            //throw new NotImplementedException();
            Console.WriteLine("NOM/PRENOM/ANNEE DE NAISSANCE/ANNEE DE DECES/AGE");
            int i;
            for (i = 0; i < b.GetCountAuteurs(); i++)
            {
                Auteur a = b.GetAuteur(i);
                Console.WriteLine("{0}/{1}/{2}/{3}/{4}", a.GetNom(), a.GetPrenom(), a.GetAnneeNaissance(), a.GetAnneeDeces(),  a.GetAnneeDeces() - a.GetAnneeNaissance());

            }
        }


        private static void CaracteristiqueBibliotheque(Bibliotheque b)
        {
            //throw new NotImplementedException();
            Console.WriteLine("La bibliothèque contient " + b.GetCountLivres() + " livres");
            Console.WriteLine("Ecrit par " + b.GetCountAuteurs() + " auteurs");
            Console.WriteLine("Elle a été chargé à partir du fichier bibliotheque.txt");

        }

        private static void AfficherLivres(Bibliotheque b)
        {
            //throw new NotImplementedException();
            Console.WriteLine("TITRE/GENRE/DATE/PARUTION");
            int i;
            for (i = 0; i < b.GetCountLivres(); i++)
            {
                Livre l = b.GetLivre(i);
                Console.WriteLine("{0}/{1}/{2}", l.GetTitre(), l.GetGenre(), l.GetAnneeSortie());

            }

            

        }

    }
}
    

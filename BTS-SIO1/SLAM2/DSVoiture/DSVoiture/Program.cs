using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DllConcession;

namespace DSVoiture
{
    class Program
    {
        static void Main(string[] args)
        {
            //STANISLAS Veronical
            Concession MontmorencyReparation;

            MontmorencyReparation = Concession.CreateConcession(12);
            //ListeVoitureCouleur(MontmorencyReparation);
            //ValeurConcession(MontmorencyReparation);
            NouvelleVoiture(MontmorencyReparation);
            AfficherPrix(MontmorencyReparation.GetVoiture(8));
            
            
            Console.ReadLine();
        }
        static void ListeVoitureCouleur(Concession c)
        { 
        }
        static void ValeurConcession(Concession c)
        { 
        }
        static void NouvelleVoiture(Concession c)
        {
            //Voiture.CreateVoiture("EV-897-VE", "rouge", true, Modele.CreateModele("C3", "Citroen", 12000));
            //Console.WriteLine("Saisir l'immatriculation");
            //string s = Console.ReadLine();
            //Console.WriteLine("Saisir la couleur");
            //string s1 = Console.ReadLine();
            //Console.WriteLine("Saisir si il est en stock");
            //bool s2 = Convert.ToBoolean(true);
            //string s22 = Console.ReadLine();
            //Console.WriteLine("Saisir le modèle");
            //string s3 = Console.ReadLine();

            if (c.AjouterVoiture(Voiture.CreateVoiture("EV-897-VE", "rouge", true, Modele.CreateModele("C3", "Citroen", 12000))))
            {
                Console.WriteLine("La voiture a pu être ajoutée à la concession");
            }
            else
            {
                Console.WriteLine("La voiture n'a pas pu être ajoutée à la concession");
            }

            
        }
        static void AfficherPrix(Voiture v, Modele m, Option o)
        {
            Console.WriteLine("Immatriculation : {0}", v.GetImmatriculation());
            Console.WriteLine("Modèle : {1}", m.GetNom());
            Console.WriteLine("Marque : {2}", m.GetMarque());
            Console.WriteLine("Prix : {3}", m.GetPrix());
            Console.WriteLine("{4} : {5}", o.GetLibelle(),o.GetPrix());
            Console.WriteLine("{6} : {7}", o.GetLibelle(),o.GetPrix());
            Console.WriteLine("{8} : {9}", o.GetLibelle(),o.GetPrix());
            Console.WriteLine("{10} : {11}", o.GetLibelle(),o.GetPrix());
            Console.WriteLine("Prix total : {12}", m.GetPrix() + o.GetPrix());

            
            

        }
    
    }
}

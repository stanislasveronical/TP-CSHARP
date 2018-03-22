using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CompteBanquaire;

namespace UtiliserCompteBanquaire
{
    class Program
    {
        static void Main(string[] args)
        {

            Banque b = new Banque(25, "CL");
            Banque b1 = new Banque (10,"CL");
            Banque b2 = new Banque(10, "SG");
            

            Console.WriteLine("*-----BanqueTableau-----*");
            Compte c1 = new Compte("J.DUPONT", 1000);
            Compte c2 = new Compte("C.DURANT", 50000,6000,5000);

            b1.Add(new Compte("Daniel", 1000));
            b1.Add("Sam Lowry", 1000);
            b1.Add("Jack Lint", 200);
 
            b1.Add(c1);
            b1.Add(c2);
            
            
            List<Compte> mesComptes = new List<Compte>();

            mesComptes.Add(new Compte("C.DURANT", 50000, 6000, 5000));
            //Compte desComptes = mesComptes[2];

            BanqueCollection bc = new BanqueCollection("CL");
            Console.WriteLine("Cumul des Soldes de la Banque : {0}",bc.ValeurDepotsBanque());

       

            for (int i = 0; i < b1.Count; i = i + 1)
            {
                //Compte unCompte = b1.GetCompte(i);
                Compte unCompte = b1[i];
                Console.WriteLine(unCompte.ToString());   
            }

            Console.WriteLine("Cumul des Soldes de la Banque : {0}", bc.ValeurDepotsBanque());

            Console.ReadLine();
        }
    }
}

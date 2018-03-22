using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EX6
{
    class Program
    {
        static void Main(string[] args)
        {

            string s;
            double pu, qtcom, pap, port, rem;
            double tot;

            // Prix unitaire d'un produit
            Console.WriteLine("Saisir le prix unitaire du produit");
            s = Console.ReadLine();
            pu = Convert.ToDouble(s);

            // Quantité commandée
            Console.WriteLine("Saisir la quantité commandée");
            s = Console.ReadLine();
            qtcom = Convert.ToDouble(s);

            // Le prix à payer
            Console.WriteLine("Afficher le prix à payer");
            s = Console.ReadLine();
            pap = Convert.ToDouble(s);

            // Le port
            Console.WriteLine("Afficher le port");
            s = Console.ReadLine();
            port = Convert.ToDouble(s);

            // La remise
            Console.WriteLine("Afficher la remise");
            s = Console.ReadLine();
            rem = Convert.ToDouble(s);

            // Le prix des produits
            Console.WriteLine("Afficher le prix des produits");
            s = Console.ReadLine();
            tot = Convert.ToDouble(s);

            if (tot > 500)
            {
                Console.WriteLine("Le port est gratuit");
            }

            else
            {
                Console.WriteLine("Le port est de" + tot * 0.02 + "du tot et sa valeur minimale est de 6euros");
            }



            if (200 < tot < 1000)
            {
                Console.WriteLine("La remise est de 5%");
            }

            else
            {
                Console.WriteLine("La remise est de 10%");
            }

            Console.ReadLine();







        }
    }
}

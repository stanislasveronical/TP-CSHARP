using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EX_4
{
    class Program
    {
        static void Main(string[] args)
        {

            // variables locales à l’algorithme MINMAX 

            
            bool ok;
            int choix = 0;
            string s;

            // premier affichage du menu

            Console.WriteLine("1 : Replication de message");
            Console.WriteLine("2 : Somme des n premiers nombres entiers");
            Console.WriteLine("3 : Somme des carrés des n premiers nombres entiers");
            Console.WriteLine("4 : Elevation à la puissance (x^n)");
            Console.WriteLine("5 : Fin du programme");


            // saisie du choix
            ok = false;
            while (!ok || choix < 1 || choix > 5)
            {
                Console.WriteLine("donnez votre choix");
                ok = Int32.TryParse(Console.ReadLine(), out choix);
            }

             // boucle de traitement
            while (choix != 5)
            { 
            
            }

        }
    }
}

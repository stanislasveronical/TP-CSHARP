using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EX_2
{
    class Program
    {
        static void Main(string[] args)
        {

            string s;
            int i, borneSup, resultat;

            //Calcule de la somme des n premiers nombres entiers

            Console.WriteLine("Saisir un nombre");
            s = Console.ReadLine();
            borneSup = Convert.ToInt32(s);

            resultat = 0;
            

            for (i=1; i <= borneSup; i++)
            {
                resultat = resultat + i;
            }

            Console.WriteLine(resultat);

            //Afficher le message

            Console.ReadLine();

        }
    
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pyramide2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* programme qui dessine une pyramide */
            // déclaration des variables en mémoire 
            string s;
            char c;
            int i;
            int j;
            int nblignes;
            int rang;
            int x;
            int y;

            // Saisie du caractère à afficher
            Console.WriteLine("saisir le caractère à afficher");

            s = Console.ReadLine();
            c = Convert.ToChar(s);


            // Lignes

            Console.WriteLine("saisir le nombre de lignes de la pyramide");

            s = Console.ReadLine();
            nblignes = Convert.ToInt32(s);


            //Afficher plusieurs fois une ligne

            for (rang = 1; rang <= nblignes; rang = rang + 1)
            {
                x = nblignes - rang;
                y = 2 * (rang - 1) + 1;

                // Afficher une ligne

                for (i = 1; 1 <= x; i = i + 1)
                {
                    Console.Write('+');
                }

                for (j = 1; 1 <= y; i = i + 1)
                {
                    Console.Write(c);
                }

                for (i = 1; 1 <= x; i = i + 1)
                {
                    Console.Write('+');
                }
                Console.WriteLine();


                // pour voir le résultat
                Console.ReadLine();
            }
        }
    }
}

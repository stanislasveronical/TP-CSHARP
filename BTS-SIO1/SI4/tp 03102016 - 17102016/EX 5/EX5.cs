using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EX_5
{
    class EX5
    {
        static void Main(string[] args)
        {

            string s;
            int a, b;
         


            /*Valeur de a*/
            Console.WriteLine("Indiquer la valeur de a");
            s = Console.ReadLine();
            a = Convert.ToInt32(s);

            /*Valeur de b*/
            Console.WriteLine("Indiquer la valeur de b");
            s = Console.ReadLine();
            b = Convert.ToInt32(s);

          

            /*Le choix de l'opération : Menu */
 
            Console.WriteLine("[S] = Afficher la SOMME");
            Console.WriteLine("[P] = Afficher le PRODUIT");
            Console.WriteLine("[M] = Afficher la MOYENNE");
            Console.WriteLine("[Q] = Afficher QUOTIENT");

            Console.WriteLine("Choisissez l'opération à effectuer");
            s = Console.ReadLine();

            if (s == "S")
            {
                Console.WriteLine("Le résultat de la SOMME est {0} + {1}", a, b);
                Console.Write(a + b);
            }
            else if (s == "P")
            {
                Console.WriteLine("Le résultat du PRODUIT est {0}*{1}", a, b);
                Console.Write(a * b);
            }
            else if (s == "M")
            {
                Console.WriteLine("Le résultat de la MOYENNE est ({0}+{1})/2", a, b);
                Console.Write((a + b)/2);
            }
            else if (s == "Q")
            {
                Console.WriteLine("Le résultat du QUOTIENT est {0}/{1}", a, b);
                Console.Write(a / b);
            }


            Console.ReadLine();



        }
    }
}

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
            double largeur;
            double Longeur;
            double P;
            double A;

            Console.WriteLine("Donner la largeur");
            s = Console.ReadLine();
            largeur = Convert.ToDouble(s);

            Console.WriteLine("Donner la Longeur");
            s = Console.ReadLine();
            Longeur = Convert.ToDouble(s);

            Console.WriteLine("Le Périmétre du rectangle");
            s = Console.ReadLine();
            P = ( Longeur + largeur)*2;
            Console.WriteLine(P);

            Console.WriteLine("L'Aire du rectangle");
            s = Console.ReadLine();
            A = Longeur * largeur;
            Console.WriteLine(A);
               
            Console.ReadLine();
        }
    }
}

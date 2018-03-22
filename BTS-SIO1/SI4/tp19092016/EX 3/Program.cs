using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EX_3
{
    class Program
    {
        static void Main(string[] args)
        {

            string s;
            int nallu;
            int cap, nboites;
            int reste;

            Console.WriteLine("Donner le nombre d'allumettes");
            s = Console.ReadLine();
            nallu = Convert.ToInt32(s);

            Console.WriteLine("Donner la capacité de la boîte");
            s = Console.ReadLine();
            cap = Convert.ToInt32(s);
            nboites = Convert.ToInt32(s);

            nboites = nallu/cap;
            reste = nallu % cap;
            Console.WriteLine("Donner le nombre de boîte" + nboites);

            Console.WriteLine("Afficher le nombre d'allumettes restantes");
        

            Console.ReadLine();

        }
    }
}

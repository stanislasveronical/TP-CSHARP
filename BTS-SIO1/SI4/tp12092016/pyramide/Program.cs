using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pyramide
{
    class Program
    {
        static void Main(string[] args)
        {
           /* programme qui dessine une pyramide */
           // déclaration des variables en mémoire 
            string s;
            char c;

            Console.WriteLine("donner la lettre à afficher");
            s = Console.ReadLine();
            c = Convert.ToChar (s);

            Console.Write("++++");
            Console.Write(""+c+"");
            Console.WriteLine("++++");

            Console.Write("+++");
            Console.Write(""+c+c+c+"");
            Console.WriteLine("+++");

            Console.Write("++");
            Console.Write(""+c+c+c+c+c+"");
            Console.WriteLine("++");

            Console.Write("+");
            Console.Write(""+c+c+c+c+c+c+c+"");
            Console.WriteLine("+");

            Console.Write(""+c+c+c+c+c+c+c+c+c+"");
           
            
            
            // pour voir le résultat
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03102016
{
    class Program
    {
        static void Main(string[] args)
        {

            string s;
            int i, j;

            

            /* Valeur de i*/
            
            Console.WriteLine("Indiquer la valeur de i");
            s = Console.ReadLine();
            i = Convert.ToInt32(s);

            /*Valeur de j*/
            
            Console.WriteLine("Indiquer la valeur de j");
            s = Console.ReadLine();
            j = Convert.ToInt32(s);

            Console.WriteLine("Afficher la valeur absolue de la différence entre 2 nombres entiers"); 

            if (i < j)
            {

                Console.WriteLine(j - i);

            }
            else if (j < i)
            {

                Console.WriteLine(i - j);

            }

          
            
            Console.ReadLine();


        }
    }
}

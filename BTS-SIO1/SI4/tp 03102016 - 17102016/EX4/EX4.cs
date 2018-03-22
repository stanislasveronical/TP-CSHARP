using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EX4
{
    class Program
    {
        static void Main(string[] args)
        {
            string s;
            int ab, bc, ac;

            /*Valeur de a*/
            Console.WriteLine("Indiquer la valeur de ab");
            s = Console.ReadLine();
            ab = Convert.ToInt32(s);

            /*Valeur de b*/
            Console.WriteLine("Indiquer la valeur de bc");
            s = Console.ReadLine();
            bc = Convert.ToInt32(s);

            /*Valeur de c*/
            Console.WriteLine("Indiquer la valeur de ac");
            s = Console.ReadLine();
            ac = Convert.ToInt32(s);
            
               if ((ab*ab) == (bc*bc) + (ac*ac)) 
            {

                Console.WriteLine("Le triangle est rectangle");

            }
               else if ((ab*ab) != (bc*bc) + (ac*ac)) 
            {

                Console.WriteLine("Le triangle n'est pas rectangle");

            }


            Console.ReadLine();
        }
    }
}

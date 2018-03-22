using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EX3
{
    class Program
    {
        static void Main(string[] args)
        {

            string s;
            int a, b;
            int x;


            /*Valeur de a*/
            Console.WriteLine("Indiquer la valeur de a");
            s = Console.ReadLine();
            a = Convert.ToInt32(s);

            /*Valeur de b*/
            Console.WriteLine("Indiquer la valeur de b");
            s = Console.ReadLine();
            b = Convert.ToInt32(s);

            

            Console.WriteLine("Résoudre l'équation");


            if (a != 0)
            {
                x = -b / a;
                Console.WriteLine("le résultat de l'équation {0}x + {1} = 0 vaut {2}",a,b,x);
            }

            else  {

                if (b==0) {
                    Console.WriteLine("l'ensemble des solutions de l'équation {0}x + {1} = 0 est R",a, b);
                }
                else {
                    Console.WriteLine("l'ensemble des solutions de l'équation {0}x + {1} = 0 est vide", a, b);
                }
 
            }

            Console.ReadLine();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EX7
{
    class EX7
    {
        static void Main(string[] args)
        {


            string s;
            double a, b, c;
            double Delta;


            // Saisie de a
            Console.WriteLine("Saisir a");
            s = Console.ReadLine();
            a = Convert.ToDouble(s);

            // Saisie de b
            Console.WriteLine("Saisir b");
            s = Console.ReadLine();
            b = Convert.ToDouble(s);

            // Saisie de c
            Console.WriteLine("Saisir c");
            s = Console.ReadLine();
            c = Convert.ToDouble(s);

            // Saisie de Delta
            Console.WriteLine("Afficher Delta");
            s = Console.ReadLine();
            Delta = Convert.ToDouble(s);


            Console.WriteLine("Afficher les résultats de la résolution (dans R) de l'équation ax²+bx+c=0");


            if (a != 0)
            {
                Delta = (b * b) - (4 * a * c);
                Console.WriteLine("le discriminant est égal à");
            }

            else
            {
                if (Delta < 0)
                {
                    Console.WriteLine("L'équation ne possède aucune solution dans R");
                }

                else if (Delta == 0)
                {
                    Delta = (-b) / (2 * a);
                    Console.WriteLine("L'équation admet 1 solution");
                }

                else if (Delta > 0)
                {

                    Delta = (-b) + Math.Sqrt(Delta) / (2 * a);
                    Delta = (-b) - Math.Sqrt(Delta) / (2 * a);
                    Console.WriteLine("L'équation admet 2 solutions");
                }

            }
            
                                                       
            Console.ReadLine();

            }
        }
    }

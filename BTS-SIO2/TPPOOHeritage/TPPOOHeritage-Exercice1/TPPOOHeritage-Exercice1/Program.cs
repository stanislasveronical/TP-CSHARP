using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TPPOOHeritage_Exercice1
{
    class Program
    {
        static void Main(string[] args)
        {
            Mammifère[]Tab=new Mammifère[3];

            Tab[0] = new Félin("Un Lion", "La Jungle", "moyen", "oui", 4);
            Tab[1] = new Félin("Un Chat", "La Maison", "faible", "oui", 4);
            Tab[2] = new Cétacé("Une Baleine", "L'Océan", "moyen", "non", 120, 1200);

            
            Tab[0].Afficher();

            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine("Animal n° " + i);
            //    Console.WriteLine(Tab[i].ToString());
            //    Console.WriteLine(Tab[i].JeSuisDangereux());
            //    Console.WriteLine(" ");
            //}

            int choix;
            Console.WriteLine("Faites votre choix !");

            Console.WriteLine("0 - Un Lion");
            Console.WriteLine("1 - Un Chat");
            Console.WriteLine("2 - Une Baleine");

            choix = Convert.ToInt32(Console.ReadLine());

            switch (choix)
            {
                case 0:
                    for (int i = 0; i < 1; i++)
                    {
                        Console.WriteLine("Animal n° " + i);
                        Console.WriteLine(Tab[i].ToString());
                        Console.WriteLine(Tab[i].JeSuisDangereux());
                        Console.WriteLine(" ");
                    }
                    Console.WriteLine("Vous avez choisi d'adopter Un lion");
                    break;
                case 1:
                    Console.WriteLine("Vous avez choisi d'adopter Un chat");
                    break;
                case 2:
                    Console.WriteLine("Vous avez choisi d'adopter Une baleine");
                    break;
                default:
                    Console.WriteLine("Default case");
                    break;
            }

            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TP_4
{
    class Program
    {
        static void Main(string[] args)
        {

            string message, s;
            int nbfois, i;

            //Saisie du nombre entier n

            Console.WriteLine("Saisir le nombre de répétitions");
            s= Console.ReadLine();
            nbfois = Convert.ToInt32(s);

            //Saisie du message

            Console.WriteLine("Saisir le message à afficher");
            message = Console.ReadLine();
            
                        
            //Afficher le message

            Console.WriteLine("Afficher le message");

            for (i = 1; i <= nbfois; i++)
            {
                        
            Console.WriteLine(message);
            }

            

            Console.ReadLine();
        }
    }
}

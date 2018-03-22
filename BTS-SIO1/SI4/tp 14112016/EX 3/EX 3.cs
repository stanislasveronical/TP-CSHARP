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
            int  i, borneSup,Resultat;



            //Valeur de la borne Supérieur     
            
            Console.WriteLine("Saisir la borneSup");
            s = Console.ReadLine();
            borneSup = Convert.ToInt32(s);

            Resultat = 0;

            for (i = 1; i <= borneSup; i++)
            {
                Resultat = Resultat + i*i;
            }

            Console.WriteLine(Resultat);

            Console.ReadLine();

        }
    }
}

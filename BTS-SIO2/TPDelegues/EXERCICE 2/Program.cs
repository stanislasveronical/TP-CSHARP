using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EXERCICE_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculatrice c = new Calculatrice();
            
            //je choisis les opérations
            c.ChoixOperation(Choix.Addition);
            c.ChoixOperation(Choix.Soustraction);


            //j'ajoute les nombres à la calculatrice
            c.Add(5);
            c.Add(3);
            c.Add(2);

            //je lance le calcul
            Console.WriteLine(c.Calculer());

            Console.ReadLine();
        }
    }
}

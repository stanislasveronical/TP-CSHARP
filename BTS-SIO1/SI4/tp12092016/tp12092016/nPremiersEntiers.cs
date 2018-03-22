using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tp12092016
{
    class nPremiersEntiers
    {
        static void Main(string[] args)
        {
           /* programme qui affiche les n premiers entiers */
           // déclaration des variables en mémoire
           string s;
           int borneSup;
           int entierA_Afficher;
           // saisie de la borne supérieure à afficher sous forme de caractère
           Console.WriteLine("donner la borne supérieure à afficher");
           s = Console.ReadLine();
           // convertir la borne suppérieuren en entier
           borneSup = Convert.ToInt32(s);
           

           // première valeur à afficher

           entierA_Afficher = 1;
           // afficher les n premiers entiers
           while (entierA_Afficher <= borneSup)
           {
               Console.WriteLine(entierA_Afficher);
               entierA_Afficher = entierA_Afficher + 1;
           }
            
           // pour voir le resultat
           Console.ReadLine();
        }
    }
}

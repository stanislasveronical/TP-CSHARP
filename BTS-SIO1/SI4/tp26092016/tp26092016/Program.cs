using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tp26092016
{
    class Program
    {
        static void Main(string[] args)
        {

            int ageDuCapitaine;
            int ageDuHeros;
            string leHeros, leCapitaine, tintin;

            ageDuHeros = 22;
            Console.WriteLine(" ageDuHeros = 22;");
            Console.WriteLine("ageDuHeros : " + ageDuHeros);
            Console.ReadLine();

            ageDuCapitaine = ageDuHeros;
            Console.WriteLine(" ageDuCapitaine = ageDuHeros;");
            Console.WriteLine("ageDuHeros : " + ageDuHeros);
            Console.WriteLine("ageDuCapitaine : " + ageDuCapitaine);
            Console.ReadLine();

            ageDuCapitaine = ageDuHeros + 20;
            Console.WriteLine(" ageDuCapitaine = ageDuHeros + 20;");
            Console.WriteLine("ageDuHeros " + ageDuHeros);
            Console.WriteLine("ageDuCapitaine " + ageDuCapitaine);
            Console.ReadLine();

            //  leCapitaine = 42;

            ageDuCapitaine = ageDuCapitaine + 1;
            Console.WriteLine(" ageDuCapitaine = ageDuCapitaine + 1;");
            Console.WriteLine("ageDuHeros " + ageDuHeros);
            Console.WriteLine("ageDuCapitaine " + ageDuCapitaine);
            Console.ReadLine();

            leHeros = "tintin";
            leCapitaine = "haddock";
            tintin = "c'est le héros de l'histoire";

            Console.WriteLine(" affectation des chaines de caractères");
            Console.WriteLine("LeHeros : " + leHeros);
            Console.WriteLine("leCapitaine : " + leCapitaine);
            Console.WriteLine("Tintin : " + tintin);
            Console.ReadLine();

            leHeros = tintin;

            Console.WriteLine(" leHeros = tintin;");
            Console.WriteLine("LeHeros : {0}, leCapitaine  : {1},  Tintin :  {2} ", leHeros, leCapitaine, tintin);

            Console.ReadLine();


        }
    }
}

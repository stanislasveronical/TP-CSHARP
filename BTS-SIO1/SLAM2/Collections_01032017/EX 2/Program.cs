using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace EX_2
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList Voyelles;

            Voyelles = new ArrayList();

            Voyelles.Add("A");
            Voyelles.Add("E");
            Voyelles.Add("I");
            Voyelles.Add("O");
            Voyelles.Add("U");
            Voyelles.Add("Y");

            for (int i = 0; i < Voyelles.Count; i = i + 1)
            {
                Console.WriteLine("{0} est une voyelle de l'alphabet", Voyelles[i]);
            }

            Console.ReadLine();
        }
    }
}

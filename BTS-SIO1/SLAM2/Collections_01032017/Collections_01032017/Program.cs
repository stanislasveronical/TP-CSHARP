using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Collections_01032017
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList Numeriques;

            Numeriques = new ArrayList();

            Numeriques.Add(0);
          

            for (int i = 0; i < 7; i=i+1 )
            {
                Console.WriteLine("{0}", i);
            }

            Console.ReadLine();

        }
    }
}

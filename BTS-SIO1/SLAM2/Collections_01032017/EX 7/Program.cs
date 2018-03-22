using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace EX_7
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList Collection1, Collection2, Collectionàconstituer;

            Collection1 = new ArrayList();
            Collection2 = new ArrayList();
            Collectionàconstituer = new ArrayList();

            Collection1.Add(4);
            Collection1.Add(8);
            Collection1.Add(7);
            Collection1.Add(9);
            Collection1.Add(1);
            Collection1.Add(5);
            Collection1.Add(4);
            Collection1.Add(6);

            for (int i = 0; i < Collection1.Count; i = i + 1)
            {
                Console.WriteLine("Collection 1 {0}", Collection1[i]);
            }
            
            Console.WriteLine("***********************************");

            Collection2.Add(7);
            Collection2.Add(6);
            Collection2.Add(5);
            Collection2.Add(2);
            Collection2.Add(1);
            Collection2.Add(3);
            Collection2.Add(7);
            Collection2.Add(4);

            for (int i = 0; i < Collection2.Count; i = i + 1)
            {
                
                Console.WriteLine("Collection 2 {0}", Collection2[i]);
            }

            Console.WriteLine("***********************************");



            foreach ( int i in Collectionàconstituer)
            {
                Collectionàconstituer =;
                Console.WriteLine(i);
            }
            

            Console.ReadLine();
        }
    }
}

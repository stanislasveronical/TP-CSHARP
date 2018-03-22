using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace EX_3
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList Notes;

            Notes = new ArrayList();

            Console.WriteLine("Combien de valeurs voulez vous saisir ");
            string s = Console.ReadLine();
            int i = Convert.ToInt32(s);

            while (i < Notes.Count)
            {
                
                Console.WriteLine(i);
                i = i + 1;
            }

            Console.WriteLine("Saisir valeurs des notes ");
            
            for (int k = 0; k < Notes.Count; k = k + 1)
            {
                Notes.Add(i);
                Console.WriteLine("{0} est une note déclaré ", Notes[k]); 
            }
            
            foreach (int a in Notes)
            {
                Notes.Add(a);
            }
            
            

            

            Console.ReadLine();
        }
    }
}

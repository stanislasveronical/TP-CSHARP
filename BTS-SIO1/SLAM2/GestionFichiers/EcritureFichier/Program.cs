using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace EcritureFichier
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter sw = new StreamWriter("nouveauFichier.txt");
            sw.WriteLine("un petit");
            sw.WriteLine("hello");
            sw.WriteLine("world");
            Console.ReadLine();
            sw.Close();

            
        }
    }
}

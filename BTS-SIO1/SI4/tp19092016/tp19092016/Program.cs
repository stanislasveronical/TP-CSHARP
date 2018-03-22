using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tp19092016
{
    class Program
    {
        static void Main(string[] args)
        {
            string s;
            double kms, miles;

            Console.WriteLine("Donner la distance à parcourir en kms");
            s = Console.ReadLine();
            kms = Convert.ToDouble (s);
            miles = kms * 0.621371;

            Console.WriteLine(kms + "vaut" + miles + "en miles");

            Console.WriteLine(String.Format("{0;###0,00}", kms) + "vaut" + String.Format("{0;###0,00}", miles) + "en miles");

            
            Console.ReadLine();


           





        }
    }
}

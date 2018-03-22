using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace LectureReadLine
{
    class Program
    {
        static void Main(string[] args)
        {
            
        
            StreamReader sr = new StreamReader(@"U:\Slam2\GestionFichiers\GestionFichiers\bin\Debug\monFichier.txt");
            string line = sr.ReadLine();

            while (line != null)
            {
                Console.WriteLine(line);
                line = sr.ReadLine();
            }

            Console.ReadLine();

            //On ferme 
            sr.Close();
        
        }
    }
}

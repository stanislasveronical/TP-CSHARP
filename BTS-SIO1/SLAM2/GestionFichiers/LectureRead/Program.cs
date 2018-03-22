using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace LectureRead
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(@"U:\Slam2\GestionFichiers\GestionFichiers\bin\Debug\monFichier.txt");
            char[] buffer = new char[6];

            int lus= sr.Read(buffer, 0, 6);
            while (lus>0)
            {
                Console.Write(buffer);
                lus = sr.Read(buffer, 0, 6);
            }
            
            Console.Write(buffer,0,2);
            Console.ReadLine();

            //On ferme 
            sr.Close();
        }
    }
}

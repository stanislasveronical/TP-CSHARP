using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace GestionFichiers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Déclaration, Instanciation et Ouverture du Fichier
            StreamReader sr = new StreamReader(@"U:\Slam2\GestionFichiers\GestionFichiers\bin\Debug\monFichier.txt");
            //StreamReader sr = new StreamReader(@"U:\Slam2\GestionFichiers\GestionFichiers\bin\Debug\monFichierTexte.txt");
            //StreamReader sr = new StreamReader(@"U:\Slam2\GestionFichiers\GestionFichiers\Program.cs");

            //Ici une lecture Fonction utilisant la méthode LectureReadToEnd

            string line = sr.ReadToEnd();

            while (line != null)
            {
                Console.WriteLine(line);
                line = sr.ReadLine();
            }

            Console.ReadLine();

            
            //On ferme 
            sr.Close();


            // Test d'existence de fichier
            try
            {
                sr = new StreamReader("monFichiert.txt");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Le fichier" + ex.Message + "n'existe pas");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                sr.Close();
            }

            Console.ReadLine();

            //Gestion de la fin de fichier




        }

               
            
    }
}

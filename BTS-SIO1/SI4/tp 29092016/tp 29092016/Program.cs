using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tp_29092016
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Afficher les mentions obtenues au baccalauréat au premier tour */


            string s;
            int note;



            note = Convert.ToInt32(s);
            Console.WriteLine("Indiquer la note obtenue au baccalauréat");

            Console.ReadLine();


      
                if note>=16 ;
                     /*La note obtenue au baccalauréat est suppérieur ou égale à 16/20 */
                    Console.WriteLine("Mention Très Bien");
                else;
     

                if 14<=note & note<16 ;
                    /*La note obtenue au baccalauréat est comprise entre 14/20 inclus et 16/20 */
                    Console.WriteLine("Mention Bien");
                else;

                if 12<=note & note<14 ;
                    /*La note obtenue au baccalauréat est comprise entre 12/20 inclus et 14/20 */
                    Console.WriteLine("Mention Assez Bien");
                else;

                if 10<=note & note<12 ;
                    /*La note obtenue au baccalauréat est comprise entre 10/20 inclus et 12/20 */
                    Console.WriteLine("Passable Sans Mention");
                else;


                if note<10 ;
                    /*La note obtenue est strictement inférieure à 10/20 */
                    Console.WriteLine("Refusé");
                else;


            }

            Console.ReadLine();
        }
    }
}

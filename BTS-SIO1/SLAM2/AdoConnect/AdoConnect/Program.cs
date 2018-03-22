using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace AdoConnect
{
    class Program
    {
        static void Main(string[] args)
        {
            ConnectionJoyeuxAnniversaire.GetConnection();
            
            

            TableAnniversaire comptage = new TableAnniversaire();
            comptage.CompteOccurence();
            comptage.CompteOccurence(1904);

            DateTime date1 = new DateTime(1904, 07, 10);
            Anniversaire anniversaire = new Anniversaire(1, date1, "Veronical", "Stanislas", "ed", "ve");

            Console.WriteLine(anniversaire.ToString());

            TableAnniversaire UnePremiereLettre = new TableAnniversaire();
 
            
            UnePremiereLettre.LeNomPatronymiqueCommencePar("s");

            Console.ReadLine();
        }
    }
}

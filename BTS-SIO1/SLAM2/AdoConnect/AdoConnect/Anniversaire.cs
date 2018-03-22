using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace AdoConnect
{
    class Anniversaire
    {
        DateTime dateAnniversaire;
        int id;
        string nom;
        string nomPseudonyme;
        string prenom;
        string prenomPseudonyme;

        public Anniversaire(int Id, DateTime DateAnniversaire, string PrenomPseudonyme, string NomPseudonyme, string Prenom, string Nom)
        {
            Console.WriteLine("Saisir id, dateAnniversaire, prenomPseudonyme, nomPseudonyme, prenom, nom");
            id = Id;
            dateAnniversaire = DateAnniversaire;
            nomPseudonyme = NomPseudonyme;
            prenomPseudonyme = PrenomPseudonyme;
            nom = Nom;
            prenom = Prenom;

            //id = Convert.ToInt32(Console.ReadLine());
            //dateAnniversaire = Convert.ToDateTime(Console.ReadLine());
            //prenomPseudonyme = Console.ReadLine();
            //nomPseudonyme = Console.ReadLine();
            //prenom = Console.ReadLine();
            //nom = Console.ReadLine();
    
        }

        public Anniversaire(DateTime dateAnniversaire, string prenomPseudonyme, string nompseudonyme, string prenom, string nom)
        {
            Console.WriteLine("Saisir dateAnniversaire, prenomPseudonyme, nomPseudonyme, prenom, nom");
            
            dateAnniversaire = Convert.ToDateTime(Console.ReadLine());
            prenomPseudonyme = Console.ReadLine();
            nompseudonyme = Console.ReadLine();
            prenom = Console.ReadLine();
            nom = Console.ReadLine();

        }
        
        public override string  ToString()
        {
            return string.Format("{0} {1} {2} {3} {4} {5}", id, nomPseudonyme, prenomPseudonyme, dateAnniversaire.Day,dateAnniversaire.Month, dateAnniversaire.Year);
        }


    }
}

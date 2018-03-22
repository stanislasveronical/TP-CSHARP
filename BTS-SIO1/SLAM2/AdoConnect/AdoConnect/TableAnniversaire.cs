using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace AdoConnect
{
    class TableAnniversaire
    {
        private MySqlConnection connection;

        private MySqlCommand deleteAnniversaire;
        private MySqlCommand insertAnniversaire;
        private MySqlCommand updateAnniversaire;

     
        public TableAnniversaire()
        {
            this.connection = ConnectionJoyeuxAnniversaire.GetConnection();
        }

        public int CompteOccurence()
        {
            this.connection.Open();

            string sCmdCount = "select count(*) from anniversaire";
            MySqlCommand selectAnniversaire = new MySqlCommand(sCmdCount, connection);

            int count = Convert.ToInt32(selectAnniversaire.ExecuteScalar());
            Console.WriteLine("Il y a {0} enreg dans la table anniversaire", count);

            Console.ReadLine();

            this.connection.Close();
            
            return 0;
        }

        public int CompteOccurence(int annee)
        {
            //this.connection.Open();

            //string sCmdCount = "select nom, prenom, dateAnniversaire from anniversaire where dateAnniversaire=@dateAnniversaire";
            //MySqlCommand selectAnniversaire = new MySqlCommand(sCmdCount, connection);

            //int count = Convert.ToInt32(selectAnniversaire.ExecuteScalar());
            //Console.WriteLine("Il y a {0} enreg de l'année spécifiée dans la table anniversaire", count);

            //Console.ReadLine();

            //this.connection.Close();
            return 0;
        }

        public string LeNomPatronymiqueCommencePar(string debutNom)
        {
            this.connection.Open();
            Console.WriteLine("Choisissez les premières lettres d'un nom");
            string sctNom = "select nom, prenom, dateAnniversaire from anniversaire where nom=@nom";
            MySqlCommand selectAnniversaire = new MySqlCommand(sctNom, connection);

            MySqlDataReader reader = selectAnniversaire.ExecuteReader();
            while (reader.Read())
            {
                Console.Write(reader["nom"]);
                Console.Write(reader["prenom"]);
                Console.WriteLine(reader["dataAnniversaire"]);
            }
            reader.Close();
            Console.ReadLine();
            this.connection.Close();
            return null;
        }

        public void Delete(int id)
        { 
        }

        public int Insert(Anniversaire nouvelAnniversaire)
        {
            return 0;
        }

        public List<Anniversaire> PlusAgesQue(int age)
        {
            return null;
        }

        public List<Anniversaire> QuiEstNeCeJour(int jour, int mois)
        {
            return null;
        }

        public List<string> RepartitionAnniversaireParMois()
        {
            return null;
        }

        public void Update(Anniversaire unAnniversaire)
        {
        }

    }
}

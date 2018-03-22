using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace AccesMySql
{
    class Program
    {
        static void Main(string[] args)
        {
            //Connection à la base
            string sCnx = "user=root;password=siojjr;database=basePersonne;host=localhost";
            MySqlConnection connexion = new MySqlConnection(sCnx);

            connexion.Open();

            //Modifier la base
            string sCmd = "insert into personne(id,nom,age) values(1,'albert',21)";
            MySqlCommand cmd = new MySqlCommand(sCmd, connexion);

            cmd.ExecuteNonQuery();

            //Requete tenant compte de parametres
            Console.WriteLine("Saisir id, nom, age");
            int id = Convert.ToInt32(Console.ReadLine());
            string nom = Console.ReadLine();
            int age = Convert.ToInt32(Console.ReadLine());

            
            string sCmd1 = "insert into personne(id,nom,age) values(@id,@nom,@age)";
            Console.WriteLine("Saisie réussie");
            MySqlCommand cmd1 = new MySqlCommand(sCmd1, connexion);

            MySqlParameter pId = new MySqlParameter("@id", id);
            MySqlParameter pNom = new MySqlParameter("@nom", nom);
            MySqlParameter pAge = new MySqlParameter("@age", age);

            cmd1.Parameters.Add(pId);
            cmd1.Parameters.Add(pNom);
            cmd1.Parameters.Add(pAge);

            cmd1.ExecuteNonQuery();

            //Suppression
            Console.WriteLine("Saisir id de la personne à supprimer");
            int idD = Convert.ToInt32(Console.ReadLine());

            string cmdDelete = "delete from personne where id=@id";
            Console.WriteLine("Suppression réussie");
            MySqlCommand cmdD = new MySqlCommand(cmdDelete, connexion);
            MySqlParameter pIdD = new MySqlParameter("@id", id);
            cmdD.Parameters.Remove(pIdD);
            cmdD.ExecuteNonQuery();

            //Modification
            string cmdUpdate = "update personne set age=@age";
            Console.WriteLine("Modification réussie");
            MySqlCommand cmdU = new MySqlCommand(cmdUpdate, connexion);
            MySqlParameter pAgeU = new MySqlParameter("@age", age);
            cmdU.Parameters.Add(pAgeU);
            cmdU.ExecuteNonQuery();


            //Requete recuperant un résultat sur la base
            string sCmdCount = "select count(*) from personne";
            MySqlCommand cmdCount = new MySqlCommand(sCmdCount, connexion);
            int count = Convert.ToInt32(cmdCount.ExecuteScalar());
            Console.WriteLine("Il ya {0} enreg dans la table personne", count);

            Console.ReadLine();


            //Requete recuperant un ensemble de résultats sur la base
            MySqlCommand cmdSelect = new MySqlCommand("select id,nom,age from personne",connexion);
            MySqlDataReader reader = cmdSelect.ExecuteReader();

            Console.WriteLine("Liste des enreg de la table personne");
            while (reader.Read())
            {
                Console.Write(reader["id"]);
                Console.Write(reader["nom"]);
                Console.WriteLine(reader["age"]);
            }
            reader.Close();
            Console.ReadLine();

            //Recupere du resultat d'une requete
            MySqlCommand cmdSelect1 = new MySqlCommand("select id,nom,age from personne group by nom", connexion);
            MySqlDataReader reader1 = cmdSelect.ExecuteReader();

            Console.WriteLine("Liste des enreg de la table personne");
            while (reader1.Read())
            {
                Console.Write(reader["id"]);
                Console.Write(reader["nom"]);
                Console.WriteLine(reader["age"]);
            }
            reader1.Close();
            Console.ReadLine();

            connexion.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace AdoConnect
{
    static class ConnectionJoyeuxAnniversaire
    {
        static string sConnection;
        static MySqlConnection connection;

        static ConnectionJoyeuxAnniversaire(){

        //Connection à la base
            sConnection = "user=root;password=siojjr;database=baseAnniversaire;host=localhost";
            connection = new MySqlConnection(sConnection);
         }

        public static MySqlConnection GetConnection()
        {
            return connection;
        }

    }
}

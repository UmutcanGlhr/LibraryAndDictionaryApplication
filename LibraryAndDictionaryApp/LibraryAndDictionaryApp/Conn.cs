using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;
namespace LibraryAndDictionaryApp
{
    class Conn
    {
        private static string mysqlcon = @"Server=localhost;Database=libraryanddictionary;Uid=root;Pwd='mysql1234';";
        private static MySqlConnection con = new MySqlConnection();
        private static MySqlDataAdapter da = new MySqlDataAdapter();
        private static MySqlCommand cmd = new MySqlCommand();

        public static void baglanti()
        {
            con = new MySqlConnection(mysqlcon);
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }

        }

        public static object Command(string query)
        {

            object obj;
            cmd.Connection = con;
            cmd.CommandText = query;
            obj = cmd.ExecuteScalar();

            return obj;
        }
        public static DataTable Table(string query)
        {
            DataTable dt = new DataTable();
            cmd.Connection = con; // SqlCommand
            cmd.CommandText = query; // SqlCommand
            da.SelectCommand = cmd; // // SqlCommand'ın bir select sorgusu olduğunu belirtiyoruz.
            da.Fill(dt);
            return dt;
        }
            
        



    }
}

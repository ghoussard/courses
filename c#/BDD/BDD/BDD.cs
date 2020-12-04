using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDD
{
    class BDD
    {

        private static SqlConnection connection;
        

        public static bool connexion()
        {
            try
            {
                connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\ghoussard\\Workspace\\courses\\c#\\databases\\bdd.mdf;Integrated Security=True;Connect Timeout=30");
                connection.Open();
            } catch (Exception e)
            {
                Console.WriteLine(e);
                connection = null;
            }
            
            return connection != null;
        }

        public static void deconnexion()
        {
            connection.Close();
            connection = null;
        }

        public static List<Contact> lireContacts()
        {
            List<Contact> lc = new List<Contact>();

            SqlCommand command = connection.CreateCommand();
            command.CommandText = "select id, nom, prenom, téléphone from contact";
            SqlDataReader reader = command.ExecuteReader();

            while(reader.Read())
            {
                lc.Add(new Contact(
                    reader.GetInt32(0),
                    reader.GetString(1),
                    reader.GetString(2),
                    reader.GetString(3)
                ));
            }

            reader.Close();
        
            return lc;
        }

        public static Contact lireContact(int id)
        {
            List<Contact> lc = new List<Contact>();

            SqlCommand command = connection.CreateCommand();
            command.CommandText = "select id, nom, prenom, téléphone from contact where id = " + id;
            SqlDataReader reader = command.ExecuteReader();

            Contact c = null;

            if(reader.Read())
            {
                c = new Contact(
                    reader.GetInt32(0),
                    reader.GetString(1),
                    reader.GetString(2),
                    reader.GetString(3)
                );
            }

            reader.Close();

            return c;
        }
    }
}

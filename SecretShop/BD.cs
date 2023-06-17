using Microsoft.Data.SqlClient;
using MySqlConnector;

namespace SecretShop
{
    public static class Bd
    {
        static string connectionString = "Server=localhost;Database=shopdb;UID = root; password = 3485;";
        public static void CreateBd()
        {
            using (MySqlConnection connection = new MySqlConnection(Bd.connectionString))
            {
                connection.Open();  

                MySqlCommand command = new MySqlCommand();
                command.CommandText = "CREATE DATABASE newBD";
                command.Connection = connection;
                command.ExecuteNonQuery();
            }
        }
        public static void CreateTable()
        {
            using (MySqlConnection connection = new MySqlConnection(Bd.connectionString)) 
            {
                connection.Open ();
                MySqlCommand command = new MySqlCommand();
                command.CommandText = "CREATE TABLE Shop (Id integer auto_increment primary key, Name varchar(50) not null, Description varchar(350) not null, Image varchar(100) NOT NULL, ReleaseDate DATE NOT NULL, AUTHOR VARCHAR(50) NOT NULL, PathToFile VARCHAR(100) NOT NULL)";
                command.Connection = connection;
                command.ExecuteNonQuery();
            }
        }
        public static List<Plugin> GetData()
        {
            List<Plugin> plugins = new List<Plugin>();
            string sqlExpression = "SELECT * FROM Plugin";
            using (MySqlConnection connection = new MySqlConnection(Bd.connectionString))
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(sqlExpression, connection);
                MySqlDataReader reader = command.ExecuteReader();
                while(reader.Read())
                {
                    Plugin plugin = new Plugin();
                    plugin.Id = reader.GetInt32(0);
                    plugin.Name = reader.GetString(1);
                    plugin.Description = reader.GetString(2);
                    plugin.Image = reader.GetString(3);
                    plugin.ReleaseDate = reader.GetDateOnly(4).ToDateTime(TimeOnly.Parse("00:00 PM"));
                    plugin.Author = reader.GetString(5);
                    plugin.PathToFile = reader.GetString(6);
                    plugin.Price = reader.GetInt32(7);
                    plugin.Rating = reader.GetInt32(8);
                    plugin.Category = reader.GetString(9);
                    plugins.Add(plugin);
                }
            }
                    return plugins;
        }

        
    }
}       

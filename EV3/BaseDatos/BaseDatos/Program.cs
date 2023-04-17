using System;
using System.Data;
using System.Data.SqlClient;

namespace BaseDatos
{
    public static class DataAcess
    {
        private static SqlConnection SqlConnection;
        private static SqlCommand sqlCommand;
        private static SqlDataReader sqlDataReader;

        static void Main(string[] args)
        {
            try
            {
                string connectionString = "Data Source=DESKTOP-8BKVIRT\\SQLEXPRESS;Initial Catalog=PROGRAMACION;User Id=;Password=;";
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                string query = "SELECT * FROM USUARIO";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine(reader["ID, NAME_USER, SURNAME, AGE"]);
                }
                reader.Close();
                connection.Close();
            }
            catch 
                (SqlException e)
                when (e.InnerException == null)
            {
                Console.WriteLine("fallo de acceso en " + e);
                Console.WriteLine(e.ToString());
                Console.WriteLine("Done. Press enter.");
                Console.ReadLine();
            }
        }
    }
}
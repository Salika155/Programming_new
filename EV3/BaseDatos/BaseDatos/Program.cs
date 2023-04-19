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
                using SqlConnection connection = new SqlConnection("Data Source=192.168.56.101,1433;Initial Catalog=PROGRAMACION;User Id=sa;Password=SqlServer123;Connection Timeout=30;");
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SELECT NAME_USER, SURNAME1 FROM USUARIO WHERE NAME_USER LIKE @filter", connection))
                    {
                        command.Parameters.AddWithValue("@filter", "%na%");
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string NAME_USER = reader.GetFieldValue<string>(0);
                                string SURNAME1 = reader.GetFieldValue<string>(1);
                                int AGE = reader.GetFieldValue<int>(2);
                                Console.WriteLine(reader["NAME_USER, SURNAME1, AGE"]);
                                reader.Close();
                                connection.Close();
                            }
                        }
                    }
                }
            }
            catch
                (SqlException exception)
                when (exception.InnerException == null)
            {
                Console.WriteLine("fallo de acceso en " + exception);
                Console.WriteLine(exception.ToString());
            }
        }
    }
}

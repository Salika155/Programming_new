using System.Data.SqlClient;

namespace WPF_BacklogData
{
    public class PruebaConexionBBDD
    {
        static void Main()
        {
            string connectionString = "Data Source=192.168.56.101; Initial Catalog=WPF_JUEGOS; User ID=sa; Password=SqlServer123";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    Console.WriteLine("Conexión exitosa a la base de datos.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al conectar a la base de datos: {ex.Message}");
            }
        }
    }
}

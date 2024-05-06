using System.Data.Common;
using System.Data.SqlClient;
;

namespace TestDB
{
    internal class Program
    {
        public const string ConnectionString = "Data Source=192.168.56.101; Initial Catalog=WPF_APP_BD; ID=sa; Password=SqlServer123";
        public static void TestConnection()
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            connection.Dispose();

        }
        static void Main(string[] args)
        {
            TestConnection();
        }
    }
}
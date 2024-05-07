using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;

namespace TestDB
{
    internal class Program
    {
        public const string ConnectionString = "Data Source=192.168.56.101; Initial Catalog=WPF_APP_BD; ID=sa; Password=SqlServer123";
        public static void TestConnection()
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                try
                {
                    connection.Open();
                }
                catch (SqlException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            //connection.Dispose();
        }

        public static void TestInsert()
        {
            string name = "";
            int age = 16;
            string query = "INSERT INTO students (nombre, edad) VALUES (@Nombre, @Edad)";
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Nombre", name);
                        command.Parameters.AddWithValue("@Edad", age);
                        int rowaAffected = command.ExecuteNonQuery();
                        //esto es para los test
                        Debug.Assert(rowaAffected == 0);
                        //if (rowaAffected > 0)
                        //    throw new Exception("No se pudo insertar el registro");
                        
                    }   
            }
            //connection.Dispose();
        }

        public static void TestInsert2()
        {
            ExecuteInsert("Juan", 20);
        }

        public static void TestSelect()
        {
            string studentName = "Ana";
            long id = ExecuteInsert(studentName, 12);
            string query = "SELECT id, name, age, description FROM students WHERE id = @StudentId";
            
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@StudentId", id);
                    using (var cursor = command.ExecuteReader())
                    {
                        while (cursor.Read())
                        {
                            //var type = cursor.GetFieldType(0);
                            var idStudent = Convert.ToInt64(cursor.GetValue(0));
                            //var nameStudent = cursor["Name"];
                            var nameStudent = cursor.GetString(1);
                            var ageStudent = Convert.ToInt32(cursor.GetValue(2));
                            //Student s = new Student(idStudent, nameStudent, ageStudent);
                            Debug.Assert(nameStudent == studentName);
                        }

                    }
                    

                }
            }
            //connection.Dispose();
        }

        public static long ExecuteInsert(string name, int age)
        {
            string query = "INSERT INTO students (nombre, edad) VALUES (@Nombre, @Edad)";
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Nombre", name);
                    command.Parameters.AddWithValue("@Edad", age);
                    var idGenerado = Convert.ToInt64(command.ExecuteScalar());
                    return idGenerado;
                }
            }
            //connection.Dispose();
        }



        static void Main(string[] args)
        {
            TestConnection();
        }
    }
}
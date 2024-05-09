using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace Model
{
    public class DatabaseSQL : IDatabase
    {
        private static DatabaseSQL _database = new DatabaseSQL();
        public const string connectionString = "Data Source=192.168.56.101; Initial Catalog=WPF_APP_BD; ID=sa; Password=SqlServer123";
        //private string connectionString = "YourConnectionStringHere";
        public static DatabaseSQL Instance => _database;
        //public int StudentCount => _students.Count;

        private DatabaseSQL()
        {

        }

        public void AddStudent(Student student)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using SqlCommand command = new SqlCommand("AddStudentProcedure", connection);
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Name", student.Name);
                    command.Parameters.AddWithValue("@Age", student.Age);
                    command.Parameters.AddWithValue("@Description", student.Description);
                    command.ExecuteNonQuery();
                }
                
            }
        }

        public Student? GetStudent(long id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using SqlCommand command = new SqlCommand("GetStudentByIdProcedure", connection);
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Id", id);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Student
                            {
                                Id = (long)reader["Id"],
                                Name = (string)reader["Name"],
                                Age = (int)reader["Age"],
                                Description = (string)reader["Description"]
                            };
                        }
                        else
                        {
                            return null;
                        }
                    }
                }
                
            }
        }

        public Student? GetStudentAt(int index)
        {
            throw new NotImplementedException();
        }

        public int GetStudentCount()
        {
            throw new NotImplementedException();
        }

        public void RemoveStudent(long id)
        {
            throw new NotImplementedException();
        }

        public void UpdateStudent(Student student, long id)
        {
            throw new NotImplementedException();
        }
    }
}

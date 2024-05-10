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

        public int GetCount()
        {
            /*int("SELECT COUNT(ID) FROM STUDENTS") /* SELECT COUNT (ID) FROM STUDENTS */
            return -1;
        }


        //public int StudentCount => _students.Count;

        private DatabaseSQL()
        {

        }

        public long AddStudent(Student student)
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
            return student.Id;
        }

        public Student? GetStudentById(long id)
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
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using SqlCommand command = new SqlCommand("GetStudentByIdProcedure", connection);
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Id", index);
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

        public int GetStudentCount()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using SqlCommand command = new SqlCommand("GetStudentCountProcedure", connection);
                {
                    command.CommandType = CommandType.StoredProcedure;
                    return (int)command.ExecuteScalar();
                }
            }
        }

        public void RemoveStudent(long id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using SqlCommand command = new SqlCommand("RemoveStudentProcedure", connection);
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Id", id);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void UpdateStudent(Student student, long id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using SqlCommand command = new SqlCommand("UpdateStudentProcedure", connection);
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Id", id);
                    command.Parameters.AddWithValue("@Name", student.Name);
                    command.Parameters.AddWithValue("@Age", student.Age);
                    command.Parameters.AddWithValue("@Description", student.Description);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace Model
{
    public class DatabaseBBDD : IDatabase
    {
        private static DatabaseBBDD _database = new DatabaseBBDD();
        private string connectionString = "YourConnectionStringHere";
        public static DatabaseBBDD Instance => _database;
        //public int StudentCount => _students.Count;

        private DatabaseBBDD()
        {

        }

        public void AddStudent(Student student)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("AddStudentProcedure", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Name", student.Name);
                command.Parameters.AddWithValue("@Age", student.Age);
                command.Parameters.AddWithValue("@Description", student.Description);
                command.ExecuteNonQuery();
            }
        }

        public Student? GetStudent(long id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("GetStudentByIdProcedure", connection);
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

        Student? IDatabase.GetStudentAt(int index)
        {
            throw new NotImplementedException();
        }

        int IDatabase.GetStudentCount()
        {
            throw new NotImplementedException();
        }

        void IDatabase.RemoveStudent(long id)
        {
            throw new NotImplementedException();
        }

        void IDatabase.UpdateStudent(Student student, long id)
        {
            throw new NotImplementedException();
        }
    }
}

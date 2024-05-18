using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;
using WPF_BacklogData.Interfaces;

namespace WPF_BacklogData.Models
{
    public class DatabaseSQL : IBacklogDataBase
    {
        private static DatabaseSQL _database = new DatabaseSQL();
        public const string connectionString = "Data Source=192.168.56.101; Initial Catalog=WPF_APP_BD; ID=sa; Password=SqlServer123";
        public static DatabaseSQL Instance => _database;

        private DatabaseSQL()
        {

        }

        public void RegisterUser(User user)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = "INSERT INTO USERS (Name, email, Password) VALUES (@name, @email,  password)";
                connection.Execute(sql, user);
            }
        }

        public void AuthenticateUser(string email, string password)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = "SELECT * FROM USERS"
            }
        }

        public long AddGame(Game game)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using SqlCommand command = new SqlCommand("AddStudentProcedure", connection);
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Name", game.Name);
                    //command.Parameters.AddWithValue("@Age", game.Age);
                    command.Parameters.AddWithValue("@Description", game.Description);
                    command.ExecuteNonQuery();
                }

            }
            return game.ID;
        }

        public Game? GetGameById(long id)
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
                            return new Game
                            {
                                //Id = (long)reader["Id"],
                                Name = (string)reader["Name"],
                                //Age = (int)reader["Age"],
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

        public Game? GetGameAt(int index)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using SqlCommand command = new SqlCommand("GetStudentByIdProcedure", connection);
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@ID_Game", index);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Game
                            {
                                ID = (long)reader["Id_Game"],
                                Name = (string)reader["Name"],
                                //Age = (int)reader["Age"],
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

        public int GetGametCount()
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

        public void RemoveGame(long id)
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

        public void UpdateGame(Game game, long id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using SqlCommand command = new SqlCommand("UpdateStudentProcedure", connection);
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Id", id);
                    command.Parameters.AddWithValue("@Name", game.Name);
                    //command.Parameters.AddWithValue("@Age", game.Age);
                    command.Parameters.AddWithValue("@Description", game.Description);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}


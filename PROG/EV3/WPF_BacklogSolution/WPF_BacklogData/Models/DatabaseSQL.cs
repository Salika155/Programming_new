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
        public readonly string connectionString = "Data Source=192.168.56.101; Initial Catalog=WPF_APP_BD; ID=sa; Password=SqlServer123";
        public static DatabaseSQL Instance => _database;

        private DatabaseSQL()
        {

        }

        //esto quiero saber el por que
        //ya lo se, es para no estar haciendo new sqlconnection cada using, llama al metodo y ya esta
        //public SqlConnection GetConnection()
        //{
        //    return new SqlConnection(connectionString);
        //}



        public void AddUser(string name, string email, string password)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = "INSERT INTO USERS (Name, email, Password) VALUES (@name, @email, @password)";
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@password", password);
                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }

       //esto tengo que remirarlo de hacerlo
        public User GetUser(string email, string password)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM USER WHERE Email = @Email AND Password = @Password";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Password", password);
                connection.Open();
                
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    return new User
                    {
                        ID = reader.GetInt32(0),
                        Name = reader.GetString(1),
                        Email = reader.GetString(2),
                        Password = reader.GetString(3)
                    };
                }
                return null;
            }
        }


        //public void AuthenticateUser(string email, string password)
        //{
        //    using (SqlConnection connection = new SqlConnection(connectionString))
        //    {
        //        string sql = "SELECT * FROM USERS"
        //    }
        //}

        public void AddGame(Game game)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                //connection.Open();
                //using SqlCommand command = new SqlCommand("AddStudentProcedure", connection);
                //{
                //    command.CommandType = CommandType.StoredProcedure;
                //    command.Parameters.AddWithValue("@Name", game.Name);
                //    //command.Parameters.AddWithValue("@Age", game.Age);
                //    command.Parameters.AddWithValue("@Description", game.Description);
                //    command.ExecuteNonQuery();
                //}

                string query = @"INSERT INTO GAME (Name, Description, ReleaseYear, Rating, img, Genre_ID, Developer_ID, User_ID, Price, PurchaseDate, CompletionDate, Status)
                                 VALUES (@Name, @Description, @ReleaseYear, @Rating, @img, @Genre_ID, @Developer_ID, @User_ID, @Price, @PurchaseDate, @CompletionDate, @Status)";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Name", game.Name);
                cmd.Parameters.AddWithValue("@Description", game.Description);
                cmd.Parameters.AddWithValue("@ReleaseYear", game.ReleaseYear);
                cmd.Parameters.AddWithValue("@Rating", game.Rating);
                cmd.Parameters.AddWithValue("@img", game.Img);
                cmd.Parameters.AddWithValue("@Genre_ID", game.Genre_ID);
                cmd.Parameters.AddWithValue("@Developer_ID", game.Developer_ID);
                cmd.Parameters.AddWithValue("@User_ID", game.User_ID);
                cmd.Parameters.AddWithValue("@Price", game.Price);
                cmd.Parameters.AddWithValue("@PurchaseDate", game.PurchaseDate);
                cmd.Parameters.AddWithValue("@CompletionDate", game.CompletionDate);
                cmd.Parameters.AddWithValue("@Status", game.Status);

                connection.Open();
                cmd.ExecuteNonQuery();

            }
            //return game.ID;
        }

        //public Game? GetGameById(long id)
        //{
        //    using (SqlConnection connection = new SqlConnection(connectionString))
        //    {
        //        connection.Open();
        //        using SqlCommand command = new SqlCommand("GetStudentByIdProcedure", connection);
        //        {
        //            command.CommandType = CommandType.StoredProcedure;
        //            command.Parameters.AddWithValue("@Id", id);
        //            using (SqlDataReader reader = command.ExecuteReader())
        //            {
        //                if (reader.Read())
        //                {
        //                    return new Game
        //                    {
        //                        //Id = (long)reader["Id"],
        //                        Name = (string)reader["Name"],
        //                        //Age = (int)reader["Age"],
        //                        Description = (string)reader["Description"]
        //                    };
        //                }
        //                else
        //                {
        //                    return null;
        //                }
        //            }
        //        }
        //    }
        //}

        public List<Game> GetGamesByUser(int userId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                List<Game> games = new List<Game>();
                {
                    string query = "SELECT * FROM GAME WHERE User_ID = @User_ID";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@User_ID", userId);

                    connection.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        games.Add(new Game
                        {
                            ID = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            Description = reader.GetString(2),
                            ReleaseYear = reader.GetDateTime(3),
                            Rating = reader.GetInt32(4),
                            Img = reader.GetString(5),
                            Genre_ID = reader.GetInt32(6),
                            Developer_ID = reader.GetInt32(7),
                            User_ID = reader.GetInt32(8),
                            Price = reader.GetDecimal(9),
                            PurchaseDate = reader.GetDateTime(10),
                            CompletionDate = reader.GetDateTime(11),
                            Status = reader.GetString(12)
                        });
                    }
                }
                return games;
            }
        }


        //public Game? GetGameAt(int index)
        //{
        //    using (SqlConnection connection = new SqlConnection(connectionString))
        //    {
        //        connection.Open();
        //        using SqlCommand command = new SqlCommand("GetStudentByIdProcedure", connection);
        //        {
        //            command.CommandType = CommandType.StoredProcedure;
        //            command.Parameters.AddWithValue("@ID_Game", index);
        //            using (SqlDataReader reader = command.ExecuteReader())
        //            {
        //                if (reader.Read())
        //                {
        //                    return new Game
        //                    {
        //                        ID = (long)reader["Id_Game"],
        //                        Name = (string)reader["Name"],
        //                        //Age = (int)reader["Age"],
        //                        Description = (string)reader["Description"]
        //                    };
        //                }
        //                else
        //                {
        //                    return null;
        //                }
        //            }
        //        }
        //    }
        //}



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

        //// Método para registrar un usuario
        //public void RegisterUser(User user)
        //{
        //    using (var connection = new SQLiteConnection(_connectionString))
        //    {
        //        string sql = "INSERT INTO USER (Name, Email, Password) VALUES (@Name, @Email, @Password)";
        //        connection.Execute(sql, user);
        //    }
        //}

        //// Método para autenticar un usuario
        //public User AuthenticateUser(string email, string password)
        //{
        //    using (var connection = new SQLiteConnection(_connectionString))
        //    {
        //        string sql = "SELECT * FROM USER WHERE Email = @Email AND Password = @Password";
        //        return connection.QueryFirstOrDefault<User>(sql, new { Email = email, Password = password });
        //    }
        //}

        //// Método para obtener juegos por usuario
        //public List<Game> GetJuegosByUser(int userId)
        //{
        //    using (var connection = new SQLiteConnection(_connectionString))
        //    {
        //        string sql = "SELECT * FROM GAME WHERE User_ID = @UserId";
        //        return connection.Query<Game>(sql, new { UserId = userId }).ToList();
        //    }
        //}

        //// Método para añadir un juego
        //public void AddJuego(Game juego)
        //{
        //    using (var connection = new SQLiteConnection(_connectionString))
        //    {
        //        string sql = "INSERT INTO GAME (Name, Description, ReleaseYear, Rating, img, Genre_ID, Developer_ID, User_ID, Price, PurchaseDate, CompletionDate, Status) " +
        //                     "VALUES (@Name, @Description, @ReleaseYear, @Rating, @img, @Genre_ID, @Developer_ID, @User_ID, @Price, @PurchaseDate, @CompletionDate, @Status)";
        //        connection.Execute(sql, juego);
        //    }
        //}

        //// Método para actualizar un juego
        //public void UpdateJuego(Game juego)
        //{
        //    using (var connection = new SQLiteConnection(_connectionString))
        //    {
        //        string sql = "UPDATE GAME SET Name = @Name, Description = @Description, ReleaseYear = @ReleaseYear, Rating = @Rating, img = @img, Genre_ID = @Genre_ID, Developer_ID = @Developer_ID, User_ID = @User_ID, Price = @Price, PurchaseDate = @PurchaseDate, CompletionDate = @CompletionDate, Status = @Status WHERE ID_Game = @ID_Game";
        //        connection.Execute(sql, juego);
        //    }
        //}

        //// Método para eliminar un juego
        //public void DeleteJuego(int juegoId)
        //{
        //    using (var connection = new SQLiteConnection(_connectionString))
        //    {
        //        string sql = "DELETE FROM GAME WHERE ID_Game = @ID_Game";
        //        connection.Execute(sql, new { ID_Game = juegoId });
        //    }
        //}

        //// Método para obtener todos los géneros
        //public List<Genre> GetGenres()
        //{
        //    using (var connection = new SQLiteConnection(_connectionString))
        //    {
        //        string sql = "SELECT * FROM GENRE";
        //        return connection.Query<Genre>(sql).ToList();
        //    }
        //}

        //// Método para obtener todas las plataformas
        //public List<Platform> GetPlatforms()
        //{
        //    using (var connection = new SQLiteConnection(_connectionString))
        //    {
        //        string sql = "SELECT * FROM PLATAFORMA";
        //        return connection.Query<Platform>(sql).ToList();
        //    }
        //}

        //// Método para obtener todos los desarrolladores
        //public List<Developer> GetDevelopers()
        //{
        //    using (var connection = new SQLiteConnection(_connectionString))
        //    {
        //        string sql = "SELECT * FROM DEVELOPER";
        //        return connection.Query<Developer>(sql).ToList();
        //    }
        //}


    }
}


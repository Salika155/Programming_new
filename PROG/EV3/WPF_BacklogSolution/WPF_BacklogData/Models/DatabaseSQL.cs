
using System.Data;
using System.Data.SqlClient;
using WPF_BacklogData.Interfaces;

namespace WPF_BacklogData.Models
{
    public class DatabaseSQL : IBacklogDataBase
    {
        private static DatabaseSQL _database = new DatabaseSQL();
        public string connectionString = "Data Source=192.168.56.101; Initial Catalog=WPF_APP_BD; ID=sa; Password=SqlServer123";
        public static DatabaseSQL Instance => _database;

        private DatabaseSQL()
        {

        }

        #region oldcod
        //esto quiero saber el por que
        //ya lo se, es para no estar haciendo new sqlconnection cada using, llama al metodo y ya esta
        //public SqlConnection GetConnection()
        //{
        //    return new SqlConnection(connectionString);
        //}
        #endregion


        public void AddUser(User user)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("AddUser", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Name", user.Name);
                    cmd.Parameters.AddWithValue("@Email", user.Email);
                    cmd.Parameters.AddWithValue("@Password", user.Password);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        //esto tengo que remirarlo de hacerlo
        public User? GetUserByID(int userID)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                //string query = "SELECT * FROM USER WHERE Email = @Email AND Password = @Password";
                using (SqlCommand cmd = new SqlCommand("GetUserByID", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@UserID", userID);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new User
                            {
                                ID = (int)reader["UserID"],
                                Name = (string)reader["Name"],
                                Email = (string)reader["Email"],
                                Password = (string)reader["Password"]
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

        public User? GetUserAt(int index)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using SqlCommand command = new SqlCommand("GetUserByID", connection);
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@ID", index);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new User
                            {
                                ID = (int)reader["UserID"],
                                Name = (string)reader["Name"],
                                Email = (string)reader["Email"],
                                Password = (string)reader["Password"]
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

        //public int GetUserCount()
        //{
        //    using (SqlConnection c = new SqlConnection(connectionString))
        //    {
        //        c.Open();
        //        using SqlCommand com = new SqlCommand("GetUserCountProced", c);
        //        {
        //            c.CommandType = CommandType.StoredProcedure;
        //            return (int)c.ExecuteScalar();
        //        }
        //    }
        //}

        public void DeleteUser(int userId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                //string query = "DELETE FROM app_users WHERE User_ID = @UserId";
                using (SqlCommand cmd = new SqlCommand("DeleteUser", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@UserId", userId);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void UpdateUser(User user, int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                //string query = "UPDATE app_users SET Name = @Name, Email = @Email, Password = @Password WHERE User_ID = @UserId";
                using (SqlCommand cmd = new SqlCommand("UpdateUser", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@UserId", id);
                    cmd.Parameters.AddWithValue("@Name", user.Name);
                    cmd.Parameters.AddWithValue("@Email", user.Email);
                    cmd.Parameters.AddWithValue("@Password", user.Password);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void AddGame(Game game)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                //string query = "INSERT INTO GAME (Name, Description, ReleaseYear, Rating, img, Genre_ID, Developer_ID, User_ID, " +
                //    "Price, PurchaseDate, CompletionDate, Status) " +
                //    "VALUES (@Name, @Description, @ReleaseYear, @Rating, @img, @Genre_ID, @Developer_ID, @User_ID, @Price, @PurchaseDate, @CompletionDate, @Status)";
                using (SqlCommand cmd = new SqlCommand("AddGame", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
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
                    cmd.ExecuteNonQuery();
                }
            }
            //return game.ID;
        }

        //esto tiene que estar mal. o tiene que añadir los juegos a la lista?
        public List<Game> GetGamesByUserID(int userId)
        {
            List<Game> games = new List<Game>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                //string query = "SELECT * FROM GAME WHERE User_ID = @User_ID";
                using (SqlCommand cmd = new SqlCommand("GetGamesByUserID", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@User_ID", userId);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Game game = new Game
                            {
                                ID = (int)reader["ID_Game"],
                                Name = (string)reader["Name"],
                                Description =(string)reader["Description"],
                                ReleaseYear = (DateTime)reader["ReleaseYear"],
                                Rating = (int)reader["Rating"],
                                Img = (string)reader["img"],
                                Genre_ID = (int)reader["Genre_ID"],
                                Developer_ID =(int)reader["Developer_ID"],
                                User_ID = (int)reader["User_ID"],
                                Price = (decimal)reader["Price"],
                                PurchaseDate = (DateTime)reader["PurchaseDate"],
                                CompletionDate =(DateTime)reader["CompletionDate"],
                                Status = (string)reader["Status"]
                            };
                            games.Add(game);
                        }
                    }
                }
                return games;
            }
        }

        public List<Game> GetGamesAt(int index)
        {
            List<Game> g = new List<Game>();

            try
            {
                using (SqlConnection c = new SqlConnection(connectionString))
                {
                    c.Open();
                    using SqlCommand command = new SqlCommand("GetGamesByUserID", c);
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@User_ID", index);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Game game = new Game
                                {
                                    ID = (int)reader["ID_Game"],
                                    Name = (string)reader["Name"],
                                    Description = (string)reader["Description"],
                                    ReleaseYear = (DateTime)reader["ReleaseYear"],
                                    Rating = (int)reader["Rating"],
                                    Img = (string)reader["img"],
                                    Genre_ID = (int)reader["Genre_ID"],
                                    Developer_ID = (int)reader["Developer_ID"],
                                    User_ID = (int)reader["User_ID"],
                                    Price = (decimal)reader["Price"],
                                    PurchaseDate = (DateTime)reader["PurchaseDate"],
                                    CompletionDate = (DateTime)reader["CompletionDate"],
                                    Status = (string)reader["Status"]
                                };
                                g.Add(game);
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("error");
            }
            return g;
        }

        //public int GetGameCount()
        //{
        //    using (SqlConnection connection = new SqlConnection(connectionString))
        //    {
        //        connection.Open();
        //        using SqlCommand command = new SqlCommand("GetGameCountProcedure", connection);
        //        {
        //            command.CommandType = CommandType.StoredProcedure;
        //            return (int)command.ExecuteScalar();
        //        }
        //    }
        //}

        public void RemoveGame(int gameId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                //string query = "DELETE FROM GAME WHERE ID_Game = @GameId";
                using (SqlCommand cmd = new SqlCommand("RemoveGame", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@GameId", gameId);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void UpdateGame(Game game)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using SqlCommand command = new SqlCommand("UpdateGame", connection);
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@ID_Game", game.ID);
                    command.Parameters.AddWithValue("@Name", game.Name);
                    command.Parameters.AddWithValue("@Description", game.Description);
                    command.Parameters.AddWithValue("@ReleaseYear", game.ReleaseYear);
                    command.Parameters.AddWithValue("@Rating", game.Rating);
                    command.Parameters.AddWithValue("@Img", game.Img);
                    command.Parameters.AddWithValue("@Genre_ID", game.Genre_ID);
                    command.Parameters.AddWithValue("@Developer_ID", game.Developer_ID);
                    command.Parameters.AddWithValue("@User_ID", game.User_ID);
                    command.Parameters.AddWithValue("@Price", game.Price);
                    command.Parameters.AddWithValue("@PurchaseData", game.PurchaseDate);
                    command.Parameters.AddWithValue("@CompletionDate", game.CompletionDate);
                    command.Parameters.AddWithValue("@Status", game.Status);
                    command.ExecuteNonQuery();               
                }
            }
        }


        ////esto tengo que remirarlo de hacerlo
        //public User? GetUser(string email, string password)
        //{
        //    using (SqlConnection connection = new SqlConnection(connectionString))
        //    {
        //        connection.Open();
        //        //string query = "SELECT * FROM USER WHERE Email = @Email AND Password = @Password";
        //        using (SqlCommand cmd = new SqlCommand(query, connection))
        //        {
        //            cmd.Parameters.AddWithValue("@Email", email);
        //            cmd.Parameters.AddWithValue("@Password", password);

        //            SqlDataReader reader = cmd.ExecuteReader();
        //            if (reader.Read())
        //            {
        //                return new User
        //                {
        //                    ID = reader.GetInt32(0),
        //                    Name = reader.GetString(1),
        //                    Email = reader.GetString(2),
        //                    Password = reader.GetString(3)
        //                };
        //            }
        //            return null;
        //        }
        //    }
        //}



        public int GetGametCount()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using SqlCommand command = new SqlCommand("GetGameCount", connection);
                {
                    command.CommandType = CommandType.StoredProcedure;
                    return (int)command.ExecuteScalar();
                }
            }
        }

       

        //public void RemoveGame(long id)
        //{
        //    throw new NotImplementedException();
        //}

        //public void RemoveGame(long id)
        //{
        //    using (SqlConnection connection = new SqlConnection(connectionString))
        //    {
        //        connection.Open();
        //        using SqlCommand command = new SqlCommand("RemoveStudentProcedure", connection);
        //        {
        //            command.CommandType = CommandType.StoredProcedure;
        //            command.Parameters.AddWithValue("@Id", id);
        //            command.ExecuteNonQuery();
        //        }
        //    }
        //}


        //public void AuthenticateUser(string email, string password)
        //{
        //    using (SqlConnection connection = new SqlConnection(connectionString))
        //    {
        //        string sql = "SELECT * FROM USERS"
        //    }
        //}


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

        //QUIZAS REMOVERGAME SERIA CONVENIENTE HACERLO PASANDOLE EL NOMBRE DEL JUEGO


    }
}


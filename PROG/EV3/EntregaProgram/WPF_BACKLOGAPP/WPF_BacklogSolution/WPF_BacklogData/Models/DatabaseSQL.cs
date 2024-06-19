
using System;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using WPF_BacklogData.Interfaces;

namespace WPF_BacklogData.Models
{
    public class DatabaseSQL : IBacklogDataBase
    {
        private static DatabaseSQL _database = new DatabaseSQL();
        string connectionString = "Data Source=192.168.56.101; Initial Catalog=WPF_JUEGOS; User ID=sa; Password=SqlServer123";
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

        public List<GamePlatform> LoadPlatformsFromDatabase()
        {
            List<GamePlatform> platforms = new List<GamePlatform>();
            using (SqlConnection connection = new SqlConnection("your_connection_string"))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT Platform_ID, Platform_Name FROM PLATFORMA", connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    platforms.Add(new GamePlatform
                    {
                        Platform_ID = (int)reader["Platform_ID"],
                        Name = (string)reader["Name"]
                    });
                }
            }
            return platforms;
        }

        public void AddUser(User user)
        {
            try
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
            catch
            {
                throw new Exception("Error añadiendo");
            }
        }

        //esto tengo que remirarlo de hacerlo
        public User GetUserByID(int userID)
        {
            try
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
            catch
            {
                throw new Exception("No se pudo encontrar");
            }
            
        }

        public User? GetUserAt(int index)
        {
            try
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
            catch
            {
                throw new Exception("No se pudo encontrar");
            }
            
        }

        public void DeleteUser(int userId)
        {
            try
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
            catch
            {
                throw new Exception("No se pudo borrar");
            }
        }

        public void UpdateUser(User user, int id)
        {
            try
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
            catch
            {
                throw new Exception("No se pudo actualizar");
            }
        }

        public void AddGame(Game game)
        {
            if (game == null)
            {
                throw new ArgumentNullException(nameof(game));
            }
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    //string queryGame = "INSERT INTO GAME (Name, Description, ReleaseYear, Rating, img, Genre_ID, Developer_ID, User_ID, Price, PurchaseDate, CompletionDate, Platform_ID, Status) " +
                    //            "VALUES (@Name, @Description, @ReleaseYear, @Rating, @Img, @Genre_ID, @Developer_ID, @User_ID, @Price, @PurchaseDate, @CompletionDate, @Platform_ID, @Status); " +
                    //            "SELECT SCOPE_IDENTITY();"; // Obtiene el ID del juego insertado
                    //int gameId;
                    using (SqlCommand cmd = new SqlCommand("AddGame", connection))
                    //using (SqlCommand cmd = new SqlCommand(queryGame, connection))
                    {
                        //todo: aqui en parameters:System.NullReferenceException: 'Object reference not set to an instance of an object'
                        // wpf_backlogDataModels.Game.Description.get devolvio null
                        //cmd.CommandType = CommandType.StoredProcedure;
                        //cmd.Parameters.AddWithValue("@Name", game.Name);
                        //cmd.Parameters.AddWithValue("@Description", game.Description.ToString());
                        //cmd.Parameters.AddWithValue("@ReleaseYear", game.ReleaseDate);
                        //cmd.Parameters.AddWithValue("@Rating", game.Rating);
                        //cmd.Parameters.AddWithValue("@img", game.Img);
                        //cmd.Parameters.AddWithValue("@Genre_ID", game.Genre_ID);
                        //cmd.Parameters.AddWithValue("@Developer_ID", game.Developer_ID);
                        //cmd.Parameters.AddWithValue("@User_ID", game.User_ID);
                        //cmd.Parameters.AddWithValue("@Price", game.Price);
                        //cmd.Parameters.AddWithValue("@PurchaseDate", game.PurchaseDate);
                        //cmd.Parameters.AddWithValue("@CompletionDate", game.CompletionDate);
                        //cmd.Parameters.AddWithValue("@Status", game.GameStatus);
                        //cmd.Parameters.AddWithValue("@Platform_ID", game.Platform_ID);
                        //cmd.ExecuteNonQuery();

                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Name", game.Name ?? string.Empty);
                        cmd.Parameters.AddWithValue("@Description", string.Empty);
                        cmd.Parameters.AddWithValue("@ReleaseYear", DBNull.Value);
                        cmd.Parameters.AddWithValue("@Rating", 0);
                        cmd.Parameters.AddWithValue("@img", game.Img ?? string.Empty);
                        cmd.Parameters.AddWithValue("@Genre_ID", DBNull.Value);
                        cmd.Parameters.AddWithValue("@Developer_ID", DBNull.Value);
                        cmd.Parameters.AddWithValue("@User_ID", 1); // Default User_ID, change as needed
                        cmd.Parameters.AddWithValue("@Price", 0.0);
                        cmd.Parameters.AddWithValue("@PurchaseDate", DBNull.Value);
                        cmd.Parameters.AddWithValue("@CompletionDate", DBNull.Value);
                        cmd.Parameters.AddWithValue("@StatusGame", GameStatus.PorJugar); // Default status
                        cmd.Parameters.AddWithValue("@Platform_ID", game.Platform_ID);
                        cmd.ExecuteNonQuery();
                        
                    }

                }   
            }
            //return game.ID;
            //}
            catch (SqlException ex)
            {
                // Handle SQL exceptions (e.g., foreign key constraint violations)
                // You might want to log the exception details or provide user-friendly error messages
                throw new Exception("Error al añadir el juego: " + ex.Message);
            }
            catch (Exception ex)
            {
                // Handle other exceptions
                throw new Exception("Error al añadir el juego: " + ex.Message);
            }
            
        }

        //esto tiene que estar mal. o tiene que añadir los juegos a la lista?
        public List<Game> GetGamesByUserID(int userId)
        {
            List<Game> games = new List<Game>();

            try
            {
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
                                    Description = (string)reader["Description"],
                                    ReleaseDate = (DateTime)reader["ReleaseYear"],
                                    Rating = (int)reader["Rating"],
                                    Img = (string)reader["img"],
                                    Genre_ID = (int)reader["Genre_ID"],
                                    Developer_ID = (int)reader["Developer_ID"],
                                    User_ID = (int)reader["User_ID"],
                                    Price = (double)reader["Price"],
                                    PurchaseDate = (DateTime)reader["PurchaseDate"],
                                    CompletionDate = (DateTime)reader["CompletionDate"],
                                    GameStatus = (GameStatus)reader["Status"]
                                };
                                games.Add(game);
                            }
                        }
                    }
                    return games;
                }
            }
            catch
            {
                throw new Exception("No se pudo encontrar el juego");
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
                                    ReleaseDate = (DateTime)reader["ReleaseYear"],
                                    Rating = (int)reader["Rating"],
                                    Img = (string)reader["img"],
                                    Genre_ID = (int)reader["Genre_ID"],
                                    Developer_ID = (int)reader["Developer_ID"],
                                    User_ID = (int)reader["User_ID"],
                                    Price = (double)reader["Price"],
                                    PurchaseDate = (DateTime)reader["PurchaseDate"],
                                    CompletionDate = (DateTime)reader["CompletionDate"],
                                    GameStatus = (GameStatus)reader["Status"]
                                };
                                g.Add(game);
                            }
                        }
                    }
                }
            }
            catch
            {
                throw new Exception("No se pudo obtener el juego deseado");
            }
            return g;
        }


        public void RemoveGame(int gameId)
        {
            try
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
            catch
            {
                throw new Exception("No se pudo quitar el juego");
            }
        }

        public void RemoveGame(string gameName)
        {
            try
            {
                int gameId;
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT ID_Game FROM Game WHERE Name = @Name", connection))
                    {
                        cmd.Parameters.AddWithValue("@Name", gameName);
                        object result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            gameId = (int)result;
                        }
                        else
                        {
                            throw new Exception("No se encontró el juego con el nombre proporcionado.");
                        }
                    }
                }

                // Eliminar referencias en JUEGO_PLATAFORM
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand("DELETE FROM JUEGO_PLATAFORM WHERE Juego_ID = @ID_Game", connection))
                    {
                        cmd.Parameters.AddWithValue("@ID_Game", gameId);
                        cmd.ExecuteNonQuery();
                    }
                }

                // Ahora que no hay referencias, podemos eliminar el juego
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand("RemoveGame", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@ID_Game", gameId);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo quitar el juego: " + ex.Message);
            }
        }


        public void UpdateGame(Game game)
        {
            try
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
                        command.Parameters.AddWithValue("@ReleaseYear", game.ReleaseDate);
                        command.Parameters.AddWithValue("@Rating", game.Rating);
                        command.Parameters.AddWithValue("@Img", game.Img);
                        command.Parameters.AddWithValue("@Genre_ID", game.Genre_ID);
                        command.Parameters.AddWithValue("@Developer_ID", game.Developer_ID);
                        command.Parameters.AddWithValue("@User_ID", game.User_ID);
                        command.Parameters.AddWithValue("@Price", game.Price);
                        command.Parameters.AddWithValue("@PurchaseData", game.PurchaseDate);
                        command.Parameters.AddWithValue("@CompletionDate", game.CompletionDate);
                        command.Parameters.AddWithValue("@Status", game.GameStatus.ToString());
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch
            {
                throw new Exception("No se pudo actualizar el juego");
            }
        }

       

        public int GetGametCount()
        {
            try
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
            catch
            {
                throw new Exception("No se pudo obtener el numero de juegos");
            }
        }

        //no funciona
        public List<Game> LoadGamesFromDatabase()
        {
            List<Game> gameList = new List<Game>();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM Game", connection))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                gameList.Add(new Game
                                {
                                    ID = (int)reader["ID_Game"],
                                    Name = (string)reader["Name"],
                                    Img = (string)reader["Img"],
                                    Platform_ID = (int)reader["Platform_ID"],
                                    
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al cargar los juegos desde la base de datos: " + ex.Message, ex);
            }
            return gameList;
        }
    }
}

//QUIZAS REMOVERGAME SERIA CONVENIENTE HACERLO PASANDOLE EL NOMBRE DEL JUEGO


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Printing;
using System.Text.Json;
using Tinder_para_trastear;

namespace Tinder
{
    public class Model : IModel
    {
        public static void AddUser(User user)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection("Data Source=192.168.56.101,1433;Initial Catalog=TINDERDB;User Id=sa;Password=SqlServer123;Connection Timeout=30;"))
                {
                    connection.Open();

                    string json = JsonSerializer.Serialize<User>(user);
                    string addUser = "EXEC addUser '" + json + "'";

                    using (SqlCommand command = new SqlCommand(addUser, connection))
                    {
                        command.ExecuteNonQuery();
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            when (ex.InnerException == null)
            {
                Console.WriteLine("Error" + ex);
                Console.WriteLine(ex.ToString());
            }
        }

        public static void RemoveUser(User user)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection("Data Source=192.168.56.101,1433;Initial Catalog=TINDERDB;User Id=sa;Password=SqlServer123;Connection Timeout=30;"))
                {
                    connection.Open();

                    string json = JsonSerializer.Serialize<User>(user);
                    string removeUser = "EXEC removeUser '" + json + "'";

                    using (SqlCommand command = new SqlCommand(removeUser, connection))
                    {
                        command.ExecuteNonQuery();
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            when (ex.InnerException == null)
            {
                Console.WriteLine("Error" + ex);
                Console.WriteLine(ex.ToString());
            }
        }

        public static List<User> GetFilteredUsers(string filter, int start, int count)
        {
            List<User> userList = new List<User>();

            try
            {
                using (SqlConnection connection = new SqlConnection("Data Source=192.168.56.101,1433;Initial Catalog=TINDERDB;User Id=sa;Password=SqlServer123;Connection Timeout=30;"))
                {
                    connection.Open();

                    string getFilteredUsers = "EXEC GetFilteredUsers @filter, @start, @count";
                    using (SqlCommand command = new SqlCommand(getFilteredUsers, connection))
                    {
                        command.Parameters.AddWithValue("@filter", filter);
                        command.Parameters.AddWithValue("@start", start);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                User user = new User();
                                int ID = Convert.ToInt32(reader["ID"]);
                                string NAMEUSER = reader.GetFieldValue<string>(0);
                                int AGE = reader.GetFieldValue<int>(1);
                                string PHOTO = reader.GetFieldValue<string>(2);
                                string DESCRIPT = reader.GetFieldValue<string>(3);
                                char GENRE = reader.GetFieldValue<char>(4);
                                int RATING = reader.GetFieldValue<int>(5);
                                userList.Add(user);
                            }
                            reader.Close();
                        }
                    }
                    using (SqlCommand command = new SqlCommand())
                        connection.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error" + ex);
                Console.WriteLine(ex.ToString());
            }
            return userList;
        }

        public static void UpdateUser(User user)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection("Data Source=192.168.56.101,1433;Initial Catalog=TINDERDB;User Id=sa;Password=SqlServer123;Connection Timeout=30;"))
                {
                    connection.Open();

                    string json = JsonSerializer.Serialize<User>(user);
                    string updateUser = "EXEC updateUser @json";
                    using (SqlCommand command = new SqlCommand(updateUser, connection))
                    {
                        command.Parameters.AddWithValue("@json", json);
                        command.ExecuteNonQuery();
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            when (ex.InnerException == null)
            {
                Console.WriteLine("Error" + ex);
                Console.WriteLine(ex.ToString());
            }
        }

    }

    ////clase para crear la conexion
    //private static SqlConnection sqlConnection;
    //private static SqlCommand sqlCommand;
    //private static SqlDataReader sqlDataReader;

    //{
    //    try
    //        {
    //         using SqlConnection connection = new SqlConnection("Data Source=192.168.56.101,1433;Initial Catalog=TINDERDB;User Id=sa;Password=SqlServer123;Connection Timeout=30;");
    //            {
    //            connection.Open();

    //                string json = JsonSerializer.Serialize<User>(user);
    //                string AddUser = "EXEC addUser '" + json + "'";
    //                //string UpgradeUser = "EXEC upddateUser '" + json + "'";
    //                //string SelectUser = "EXEC SELECT * FROM dbo.GetFilteredUsers('" + json + "', 0, 10);";

    //                using (SqlCommand command = new SqlCommand(AddUser, connection))
    //                {
    //                    using (SqlDataReader reader = command.ExecuteReader())
    //                    {
    //                        while (reader.Read())
    //                        {
    //                            int ID = Convert.ToInt32(reader["ID"]);
    //                            string NAMEUSER = reader.GetFieldValue<string>(0);
    //                            int AGE = reader.GetFieldValue<int>(1);
    //                            string PHOTO = reader.GetFieldValue<string>(2);
    //                            string DESCRIPT = reader.GetFieldValue<string>(3);
    //                            char GENRE = reader.GetFieldValue<char>(4);
    //                            int RATING = reader.GetFieldValue<int>(5);
    //                            Console.WriteLine("NAMEUSER, AGE, PHOTO, DESCRIPT, GENRE, RATING");
    //                        }
    //                        reader.Close();
    //                    }
    //                }
    //            }

    //        using (SqlCommand command = new SqlCommand())
    //            connection.Close();
    //    }
    //    catch (Exception ex)
    //    when (ex.InnerException == null)
    //    {
    //        Console.WriteLine("" + ex);
    //        Console.WriteLine(ex.ToString());

    //    }

    //}


}


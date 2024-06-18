
using System.Diagnostics;
using System;
using System.Windows;
using System.Windows.Media;
using WPF_BacklogData.Models;
using WPF_BacklogData.Interfaces;
using System.Collections.ObjectModel;
using System.Windows.Controls.Primitives;
using System.Data.SqlClient;


namespace WPF_BacklogApp
{
    /// <summary>
    /// Lógica de interacción para AddRemoveGameWindow.xaml
    /// </summary>
    public partial class AddRemoveGameWindow : Window
    {
        public Game NewGame { get; set; }
        private readonly DatabaseSQL _database;
        //private ObservableCollection<Platform> _platforms;


        public AddRemoveGameWindow()
        {
            InitializeComponent();
            _database = DatabaseSQL.Instance;

            //_platforms = new ObservableCollection<Platform>(_database.LoadPlatformsFromDatabase());
            //GamePlatform.ItemsSource = _platforms;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            LoadPlatforms();
        }

        //private void LoadPlatforms()
        //{
        //    using (SqlConnection connection = new SqlConnection("your_connection_string"))
        //    {
        //        connection.Open();
        //        SqlCommand command = new SqlCommand("SELECT Platform_ID, Platform_Name FROM PLATFORMA", connection);
        //        SqlDataReader reader = command.ExecuteReader();
        //        while (reader.Read())
        //        {
        //            GamePlatform.Items.Add(new { Platform_ID = reader["Platform_ID"], Platform_Name = reader["Platform_Name"] });
        //        }
        //    }

        //    GamePlatform.DisplayMemberPath = "Platform_Name";
        //    GamePlatform.SelectedValuePath = "Platform_ID";
        //}

        

        private void LoadPlatforms()
        {
            try
            {
                List<Platform> platforms = LoadPlatformsFromDatabase();
                GamePlatform.ItemsSource = platforms;
                GamePlatform.DisplayMemberPath = "Name";
                GamePlatform.SelectedValuePath = "ID";

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar las plataformas: {ex.Message}");
            }
        }

        //public List<Platform> LoadPlatformsFromDatabase()
        //{
        //    List<Platform> platforms = new List<Platform>();
        //    using (SqlConnection connection = new SqlConnection("your_connection_string"))
        //    {
        //        connection.Open();
        //        SqlCommand command = new SqlCommand("SELECT Platform_ID, Platform_Name FROM PLATFORMA", connection);
        //        SqlDataReader reader = command.ExecuteReader();
        //        while (reader.Read())
        //        {
        //            platforms.Add(new Platform
        //            {
        //                PlatformID = (int)reader["Platform_ID"],
        //                Name = reader["Platform_Name"].ToString()
        //            });
        //        }
        //    }
        //    return platforms;
        //}

        private void AddGame_Click(object sender, RoutedEventArgs e)
        {
            {
                if (GamePlatform.SelectedValue != null)
                {
                    NewGame = new Game
                    {
                        Name = GameNameTextBox.Text,
                        Img = GameImageTextBox.Text,
                        Platform_ID = (int)GamePlatform.SelectedValue
                    };

                    try
                    {
                        _database.AddGame(NewGame);
                        MessageBox.Show($"Juego '{NewGame.Name}' añadido con éxito.");
                        DialogResult = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al añadir el juego: {ex.Message}");
                        DialogResult = false;
                    }
                    finally
                    {
                        Close();
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, selecciona una plataforma.");
                }
            }

        }

        private void RemoveGame_Click(object sender, RoutedEventArgs e)
        {
            string gameName = GameNameTextBox.Text;
            if (!string.IsNullOrEmpty(gameName))
            {
                try
                {
                    _database.RemoveGame(gameName);
                    MessageBox.Show($"Juego '{gameName}' removido con éxito.");
                    DialogResult = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al remover el juego: {ex.Message}");
                    DialogResult = false;
                }
                Close();
            }
            else
            {
                MessageBox.Show("Necesitas introducir un nombre de juego válido.");
            }

        }

        //private void ComboBox_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        //{
        //    LoadPlatforms();
        //}



        private List<Platform> LoadPlatformsFromDatabase()
        {
            return DatabaseSQL.Instance.LoadPlatformsFromDatabase();
        }
    }
}

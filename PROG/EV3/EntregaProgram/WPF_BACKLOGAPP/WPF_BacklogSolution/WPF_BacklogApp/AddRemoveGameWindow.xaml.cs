
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
        private ObservableCollection<GamePlatform> _platforms;


        public AddRemoveGameWindow()
        {
            InitializeComponent();
            _database = DatabaseSQL.Instance;
            LoadPlatforms();
            //_platforms = new ObservableCollection<Platform>(_database.LoadPlatformsFromDatabase());
            //GamePlatform.ItemsSource = _platforms;
        }

        private void AddGame_Click(object sender, RoutedEventArgs e)
        {
            //todo fallo aqui
            NewGame = new Game
            {
                Name = GameNameTextBox.Text,
                Img = GameImageTextBox.Text,
                Platform_ID = ((Game)GamePlatform.SelectedItem).Platform_ID
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
            Close();
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

        private void ComboBox_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            LoadPlatforms();
        }

        private void LoadPlatforms()
        {
            try
            {
                List<GamePlatform> platforms = _database.LoadPlatformsFromDatabase();
                _platforms = new ObservableCollection<GamePlatform>(platforms);
                GamePlatform.ItemsSource = _platforms;
                GamePlatform.DisplayMemberPath = "Name_Platform";
                GamePlatform.SelectedValuePath = "Platform_ID";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar las plataformas: {ex.Message}");
            }
        }

        //public List<GamePlatform> LoadPlatformsFromDatabase()
        //{
        //    List<Platform> platforms = new List<Platform>();
        //    using (SqlConnection connection = new SqlConnection("Data Source=192.168.56.101; Initial Catalog=WPF_JUEGOS; User ID=sa; Password=SqlServer123"))
        //    {
        //        connection.Open();
        //        SqlCommand command = new SqlCommand("SELECT Platform_ID, Name_Platform FROM PLATAFORMA", connection);
        //        SqlDataReader reader = command.ExecuteReader();
        //        while (reader.Read())
        //        {
        //            Platform platform;
        //            switch (reader["Name_Platform"].ToString())
        //            {
        //                case "PC":
        //                    platform = Platform.PC;
        //                    break;
        //                case "PS4":
        //                    platform = Platform.PS4;
        //                    break;
        //                case "XboxOne":
        //                    platform = Platform.XboxOne;
        //                    break;
        //                case "NintendoSwitch":
        //                    platform = Platform.NintendoSwitch;
        //                    break;
        //                case "PS5":
        //                    platform = Platform.PS5;
        //                    break;
        //                case "XboxSeriesX":
        //                    platform = Platform.XboxSeriesX;
        //                    break;
        //                default:
        //                    platform = Platform.Unknown;
        //                    break;
        //            }
        //            platforms.Add(platform);
        //        }
        //    }

        //    if (platforms.Count == 0)
        //    {
        //        platforms.Add(Platform.Unknown);
        //    }

        //    return platforms;
        //}
    }
}

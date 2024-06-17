
using System.Diagnostics;
using System;
using System.Windows;
using System.Windows.Media;
using WPF_BacklogData.Models;
using WPF_BacklogData.Interfaces;
using System.Collections.ObjectModel;
using System.Windows.Controls.Primitives;


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

        private void AddGame_Click(object sender, RoutedEventArgs e)
        {

            NewGame = new Game
            {
                Name = GameNameTextBox.Text,
                Img = GameImageTextBox.Text,
                //Platform_ID = GamePlatform.TabIndex,
                
            };

            try
            {
                _database.AddGame(NewGame);
                MessageBox.Show($"Juego '{NewGame.Name}' añadido con éxito.");
                DialogResult = true;
            }
            //catch (Exception ex)
            //{
            //    MessageBox.Show($"Error al añadir el juego: {ex.Message}");
            //    DialogResult = false;
            //}
            finally
            { }
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
                List<Platform> platforms = LoadPlatformsFromDatabase();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar las plataformas: {ex.Message}");
            }
        }

        private List<Platform> LoadPlatformsFromDatabase()
        {
            throw new NotImplementedException();
        }
    }
}


using System.Diagnostics;
using System;
using System.Windows;
using System.Windows.Media;
using WPF_BacklogData.Models;
using WPF_BacklogData.Interfaces;


namespace WPF_BacklogApp
{
    /// <summary>
    /// Lógica de interacción para AddRemoveGameWindow.xaml
    /// </summary>
    public partial class AddRemoveGameWindow : Window
    {
        public Game NewGame { get; set; }
        private readonly DatabaseSQL _database;


        public AddRemoveGameWindow()
        {
            InitializeComponent();
            _database = DatabaseSQL.Instance;
        }

        private void AddGame_Click(object sender, RoutedEventArgs e)
        {

            NewGame = new Game
            {
                Name = GameNameTextBox.Text,
                Img = GameImageTextBox.Text,
                Platform_ID = GamePlatform.TabIndex,
                Status = GameStatus.PorJugar
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

            //string gameName = GameNameTextBox.Text;
            //if (!string.IsNullOrEmpty(gameName))
            //{
            //    MessageBox.Show($"Juego '{gameName}' añadido con éxito.");
            //    // Aquí puedes actualizar la lista de juegos en MainWindow
            //}
            //else
            //{
            //    MessageBox.Show("Necesitas introducir un nombre de juego válido.");
            //}

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

        }
    }
}

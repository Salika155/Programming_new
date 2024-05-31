using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WPF_BacklogData.Models;

namespace WPF_BacklogApp
{
    /// <summary>
    /// Lógica de interacción para GameDetailsWindow.xaml
    /// </summary>
    public partial class GameDetailsWindow : Window
    {
        

        public Game? Game { get; set; }

        
        public GameDetailsWindow(Game game)
        {
            InitializeComponent();
            Game = game;
            GameNameTextBox.Text = game.Name;
            GameDescriptionTextBox.Text = game.Description;
            GamePlatformTextBox.Text = game.Platform_ID.ToString();
            GameReleaseDateTextBox.Text = game.ReleaseDate.ToString("yyyy-MM-dd");
            GameRatingTextBox.Text = game.Rating.ToString();
            GameImageTextBox.Text = game.Img;
            GameGenreTextBox.Text = game.Genre_ID.ToString();
            GameDeveloperTextBox.Text = game.Developer_ID.ToString();
            //GamePublisherTextBox.Text = game.Publisher;
            //GamePriceTextBox.Text = game.Price.ToString();
            //GamePurchaseDateTextBox.Text = game.PurchaseDate.ToString("yyyy-MM-dd");
            //GameCompletionDateTextBox.Text = game.CompletionDate.ToString("yyyy-MM-dd");
            //GameDurationTimeTextBox.Text = game.DurationTime.ToString("hh\\:mm\\:ss");
            //GameStatusTextBox.Text = game.Status;
        }

       

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Actualizar los campos del objeto Game
                Game.Name = GameNameTextBox.Text;
                Game.Description = GameDescriptionTextBox.Text;
                Game.Platform_ID = int.Parse(GamePlatformTextBox.Text);
                Game.ReleaseDate = DateTime.Parse(GameReleaseDateTextBox.Text);
                Game.Rating = int.Parse(GameRatingTextBox.Text);
                Game.Img = GameImageTextBox.Text;
                Game.Genre_ID = int.Parse(GameGenreTextBox.Text);
                Game.Developer_ID = int.Parse(GameDeveloperTextBox.Text);

                // Guardar los cambios y cerrar la ventana
                DialogResult = true;
                Close();
            }
            catch (Exception ex)
            {
                // Manejar cualquier error que pueda ocurrir durante la actualización
                MessageBox.Show("Error al actualizar el juego: " + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            Close();
        }
    }
}

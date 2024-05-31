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
        public Game Game { get; set; }
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
            Game.Name = GameNameTextBox.Text;
            Game.Description = GameDescriptionTextBox.Text;
            Game.Platform_ID = int.Parse(GamePlatformTextBox.Text);
            Game.ReleaseDate = DateTime.Parse(GameReleaseDateTextBox.Text);
            Game.Rating = int.Parse(GameRatingTextBox.Text);
            Game.Img = GameImageTextBox.Text;
            Game.Genre_ID = int.Parse(GameGenreTextBox.Text);
            Game.Developer_ID = int.Parse(GameDeveloperTextBox.Text);
            //Game.Publisher = GamePublisherTextBox.Text;
            //Game.Price = decimal.Parse(GamePriceTextBox.Text);
            //Game.PurchaseDate = DateTime.Parse(GamePurchaseDateTextBox.Text);
            //Game.CompletionDate = DateTime.Parse(GameCompletionDateTextBox.Text);
            //Game.DurationTime = DateTime.Parse(GameDurationTimeTextBox.Text);
            //Game.Status = GameStatusTextBox.Text;
            DialogResult = true;
            Close();
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            Close();
        }
    }
}

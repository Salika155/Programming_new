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
            GameImageTextBox.Text = game.Img;
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            Game.Name = GameNameTextBox.Text;
            Game.Img = GameImageTextBox.Text;
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
